using UnityEngine;

public class PipeSpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    public float startTime = 1.0f;
    public float spawnRate = 1.0f;
    public float heightOffset = 8.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPipe", startTime, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
