using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttacks : MonoBehaviour
{
    [SerializeField] private GameObject attackHitbox;

    private BoxCollider attackCollider;
    private MeshRenderer attackRenderer;

    private bool _hasCollided = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackCollider = attackHitbox.GetComponent<BoxCollider>();
        attackRenderer = attackHitbox.GetComponent<MeshRenderer>();

        attackCollider.enabled = false;
        attackRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwingWeapon(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Invoke(nameof(EnableAttack), 0.1f);
        }



       /* Vector3 CollisionPoint = transform.position;

        HealthComponent enemyHealth = other.GetComponent<HealthComponent>();
        if (CollisionPoint.x < other.transform.position.x)
        {
            enemyHealth.TakeDamage();
        }*/
    }

    void EnableAttack()
    {
        attackHitbox.SetActive(true);
        attackCollider.enabled = true;
        attackRenderer.enabled = true;
    }

    void DisableAttack()
    {
        attackHitbox.SetActive(false);
        attackCollider.enabled = false;
        attackRenderer.enabled = false;
    }
}
