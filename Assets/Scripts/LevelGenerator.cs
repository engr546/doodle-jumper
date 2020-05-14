using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject specialPlatform;
    public int numberOfPlatforms = 200;
    public float levelWidth = 3f; // Width of the game view
    public float minY = 2f;    // Minimum distance between platforms
    public float maxY = 5f;   // Maximum distance between platforms

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        Vector3 newSpawn = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);            
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            // Special Platform
            for (int j = 0; j < (numberOfPlatforms/10); j++)
            {
                newSpawn.y += Random.Range(10,20);    
                newSpawn.x = Random.Range(-levelWidth, levelWidth);
                if (newSpawn.x != spawnPosition.x)
                {
                    Instantiate(specialPlatform, newSpawn, Quaternion.identity);
                }
            }

        }
    }
    
}
