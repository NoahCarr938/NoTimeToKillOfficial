using UnityEngine;

public class Materials : MonoBehaviour
{
    // the amount of materials that the player has ;)
    public float mats;
    // The materials that will appear after you kill an enemy;
    [SerializeField] public GameObject MaterialPrefab;

    // Used to check health in future?
    HealthComponent healthRef;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function will be called whenever an enemy dies to drop players materials
    /*public void DropMats()
    {
        float randomMatsDropped = Random.Range(1, 5);
        Debug.Log("Mats dropped" + randomMatsDropped);
        collectedmats += randomMatsDropped;
        Debug.Log("Total Mats" + collectedmats);
    }*/

    /*public void SpawnMats()
    {
        // Should spawn at this script's position if all goes to plan ??
        Vector3 SpawnPos = transform.position;
        Quaternion SpawnRot = Quaternion.identity;

        // Spawning the game object;
        GameObject MaterialObject = Instantiate(_materialPrefab, SpawnPos, SpawnRot);
    }*/

    private void OnCollisionEnter(Collision other)
    {
        // If the game object that material is colliding with is the player
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerManager.instance.CollectMats(mats);
        }
        
    }
}
