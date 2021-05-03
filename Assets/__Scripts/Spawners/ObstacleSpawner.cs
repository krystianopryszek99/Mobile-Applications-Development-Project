using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;
public class ObstacleSpawner : MonoBehaviour
{
    // == private fields ==
    private const string SPAWN_OBSTACLE_METHOD = "SpawnOneObstacle";
   //[SerializeField] private Obstacle obstaclePrefab;

    [SerializeField] private Obstacle[] obstaclePrefab;
    [SerializeField] private SpawnPoint[] spawnPointArray;
    //[SerializeField] private GameObject[] obstacle; 
    [SerializeField] private float spawnDelay = 0.5f;
    [SerializeField] private float spawnInterval = 0.25f;

    private GameObject obstacleParent;

    // stack of spawn points
    private Stack<SpawnPoint> pointsToSpawn;
    //private SpawnPoint[] spawnPointArray; // find this at the Start()

    // Start is called before the first frame update
    void Start()
    {
        obstacleParent = GameObject.Find("ObstacleParent");
        if(!obstacleParent)
        {
            obstacleParent = new GameObject("ObstacleParent");
        }
        //spawnPointArray = GetComponentsInChildren<SpawnPoint>();
        EnableSpawning();
    }

    private void EnableSpawning()
    {
        // create a stack - fill the stack
        ShuffleSpawnPoints();
        // start spawning obstacles 
        // repeats spawning 
        InvokeRepeating(SPAWN_OBSTACLE_METHOD, spawnDelay, spawnInterval);
    }

    private void SpawnOneObstacle()
    {
        if(pointsToSpawn.Count == 0)
        {
            // fill the stack
            ShuffleSpawnPoints();
        }

        // if there is a stack that is full or that is not empty, get the next point of in
        var localSpawnPoint = pointsToSpawn.Pop();

        //int index = 0;
        //var obstacle = Instantiate(obstaclePrefab, obstacleParent.transform);
        int index = Random.Range(0, obstaclePrefab.Length);

        var obstacle = Instantiate(obstaclePrefab[index], obstacleParent.transform);
        //  random spawning - set position on the screen
        //index = Random.Range(0, spawnPoint.Length);
        //obstacle.transform.position = spawnPoint[index].transform.position;
        // from the stack - value of the stack
        obstacle.transform.position = localSpawnPoint.transform.position; 
    }

    private void ShuffleSpawnPoints()
    {
        pointsToSpawn = ListUtilities.CreateShuffledStack(spawnPointArray);
    }
}
