using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // method for spawning one pickup 
    private const string SPAWN_COIN_METHOD = "SpawnOneCoin";

    // allows to pick different pickups for different levels 
    [SerializeField] private Coin[] coinPrefab;

    // the spoint point for the pickup to spawn from
    [SerializeField] private SpawnPoint spawnPoint;

    // the spawn delay for the pickup
    [SerializeField] private float spawnDelay = 0.5f;

    // spawn interval for the pickup
    [SerializeField] private float spawnInterval = 0.1f;
    
    private GameObject coinParent;
    void Start()
    {
        coinParent = GameObject.Find("CoinParent");
        if(!coinParent)
        {
            coinParent = new GameObject("CoinParent");
        }
        // calls the EnableSpawning which then spawns one pickup
        EnableSpawning();
    }

    private void EnableSpawning()
    {
        // for spawning one pickup with that specific delay and interval
        InvokeRepeating(SPAWN_COIN_METHOD, spawnDelay, spawnInterval);
    }

    private void SpawnOneCoin()
    {
        // for random pickup
        int index = Random.Range(0, coinPrefab.Length);
        //added
        var coin = Instantiate(coinPrefab[index], coinParent.transform);
        
        coin.transform.position = spawnPoint.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
