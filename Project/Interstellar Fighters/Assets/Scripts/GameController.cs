using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public float maxTimeToSpawn;
    public float minTimeToSpawn;
    public GameObject enemy;
    public Vector3 spawnOrigin;
    public float maxXPos;
    public float minXPos;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Vector3 pos = new Vector3
                (Random.Range(minXPos, maxXPos), 
                spawnOrigin.y, 
                spawnOrigin.z);

            Instantiate(enemy, pos, enemy.transform.rotation);

            yield return new WaitForSeconds(Random.Range(minTimeToSpawn, maxTimeToSpawn));
        }
    }
}
