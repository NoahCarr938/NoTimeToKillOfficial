using System.Collections;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    // The total health ammount
    [SerializeField] private float _health = 100.0f;

    

    //private bool _canBeHit = true;
    public bool enemyKilled = false;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if health is equal to or below 0 than destroy;
        if (_health <= 0.0f)
        {
            killed();
            enemyKilled = false;
        }
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        Debug.Log(damage);
    }

    public void killed()
    {
        enemyKilled = true;
        StartCoroutine(ExecuteAfterDelay(0.5f));
        Destroy(gameObject);
       
    }

   

    IEnumerator ExecuteAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        
    }


}
