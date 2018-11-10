using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
    public GameObject[] tilePrefabs;
    
    private Transform playerTransform;
    
    private float spawnZ = 0.0f;
    
    private float tileLength = 69.7f;
	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		
        SpawnTile(); 
        
        SpawnTile();
        
        SpawnTile();
        
        SpawnTile();     
        
        
	}
	
	// Update is called once per frame
	private void Update () {
		
	}
    
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs [0]) as GameObject;
        go.transform.SetParent (transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }
}
