using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnTime = 4f;

    public float spawnPointX = 13f;

    void Start()
    {
        InvokeRepeating(
            nameof(SpawnPipe),
            0f,
            spawnTime);
    }

    void SpawnPipe()
    {
        Instantiate(
            pipePrefab,
            new Vector3(spawnPointX, 0f, 0f),
            Quaternion.identity);
    }
}