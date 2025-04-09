using System.Collections;
using UnityEngine;


public class GameController2 : MonoBehaviour
{
    public static GameController2 Instance;

    public float maxTimeToSpawn;
    public float minTimeToSpawn;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
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
            Vector3 pos2 = new Vector3
             (Random.Range(minXPos, maxXPos),
             spawnOrigin.y,
             spawnOrigin.z);
            Vector3 pos3 = new Vector3
             (Random.Range(minXPos, maxXPos),
             spawnOrigin.y,
             spawnOrigin.z);
            Vector3 pos4 = new Vector3
             (Random.Range(minXPos, maxXPos),
             spawnOrigin.y,
             spawnOrigin.z);

            Instantiate(enemy1, pos, enemy1.transform.rotation);
            Instantiate(enemy2, pos2, enemy2.transform.rotation);
            Instantiate(enemy3, pos3, enemy3.transform.rotation);
            Instantiate(enemy4, pos4, enemy4.transform.rotation);

            yield return new WaitForSeconds(Random.Range(minTimeToSpawn, maxTimeToSpawn));
        }
    }
}
