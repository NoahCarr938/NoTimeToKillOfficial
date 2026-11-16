using TMPro;
using UnityEngine;

public class WaveTimer : MonoBehaviour
{
    // The time for each wave to complete
    [SerializeField] private float _waveStartTime = 60.0f;
    // The current wave number
    [SerializeField] private int _waveNumber = 1;
    // Time text reference
    [SerializeField] private TextMeshProUGUI _waveTimeText;
    // Wave number text reference
    [SerializeField] private TextMeshProUGUI _waveNumberText;

    // The amount of time left until the end of the wave
    private float _waveTimeleft;

    // Gettter for time left
    public float WaveTimeLeft { get { return _waveTimeleft; } }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _waveTimeleft = _waveStartTime;
        if (_waveTimeText)
        {
            // Putting the wave time left into the string text and settings its format
            _waveTimeText.text = _waveTimeleft.ToString("0.0");
        }
        if(_waveNumberText)
        {
            _waveNumberText.text = _waveNumber.ToString("Wave: " + "0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Subtracting from the time left
        _waveTimeleft -= Time.deltaTime;

        // Clamping time value, cannot go below 0 and over the maximum wave start time;
        _waveTimeleft = Mathf.Clamp(_waveTimeleft, 0, _waveStartTime);

        // Making sure the text updates
        if (_waveTimeText)
        {
            _waveTimeText.text = _waveTimeleft.ToString();
        }

        if (_waveNumberText)
        {
            _waveNumberText.text = _waveNumber.ToString();
        }

        if(_waveTimeleft < 0)
        {
            _waveNumber += 1;
            _waveStartTime = 60.0f;
        }
    }
}
