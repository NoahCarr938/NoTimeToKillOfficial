using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    // Where the number of materials is displayed
    [SerializeField] private TextMeshProUGUI _materialText;

    // The total amount of materials that the player has
    public float playerTotalMats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Making sure there is material text and setting it to the player's total mats
        if (_materialText)
       _materialText.text = playerTotalMats.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (_materialText)
        {
            _materialText.text = playerTotalMats.ToString();
        }
    }

    public void CollectMats(float m)
    {
        // adding the mats collected to the total amount
        playerTotalMats += m;
        Debug.Log(playerTotalMats);
    }

}
