using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    // The total health ammount
    [SerializeField] private float _health = 100.0f;

    //private bool _canBeHit = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0.0f)
        {
            killed();
        }
    }

    public void TakeDamage()
    {
        _health -= 20;
    }

    public void killed()
    {
        Destroy(this);
    }

    
}
