using UnityEngine;

public class DealDamage : MonoBehaviour
{

    [SerializeField] private float damageTotal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie"))
        {
            HealthComponent zombie = other.GetComponent<HealthComponent>();
            zombie.TakeDamage(damageTotal);
        }
    }

}
