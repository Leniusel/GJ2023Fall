using UnityEngine;

public class EventSpawner : MonoBehaviour
{
    public GameObject itemPrefab1;
    public GameObject itemPrefab2;
    public GameObject itemPrefab3;
    public GameObject itemPrefab4;

    void Start()
    {
        SpawnRandomItemsFunction();
    }

    void SpawnRandomItemsFunction()
    {
        // List of item prefabs
        GameObject[] itemPrefabs = { itemPrefab1, itemPrefab2, itemPrefab3, itemPrefab4 };

        // Spawn two random items at different locations based on the parent object's position
        for (int i = 0; i < 2; i++)
        {
            // Randomly choose an item prefab
            int randomIndex = Random.Range(0, itemPrefabs.Length);
            GameObject randomItemPrefab = itemPrefabs[randomIndex];

            // Calculate spawn position relative to the parent object's position
            Vector3 spawnOffset = new Vector3(-2f, 0f, 0f); // Adjust offset as needed

            // Ensure the second spawn position is different from the first one
            if (i == 1)
            {
                do
                {
                    spawnOffset = new Vector3(2f, 0f, 0f);
                } while (spawnOffset == Vector3.zero); // Ensure the second offset is not zero
            }

            Vector3 spawnPosition = transform.position + spawnOffset;

            // Spawn the chosen item
            Instantiate(randomItemPrefab, spawnPosition, Quaternion.identity);
        }
    }
}