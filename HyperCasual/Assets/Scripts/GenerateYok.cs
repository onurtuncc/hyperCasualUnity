using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateYok : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public Transform playerTransform;
    float spawnZ = 0f;
    float safeZone = 10f;
    public int level = 1;
    float tileLength = 5f;
    int amnTilesOnScreen = 7;
    private List<GameObject> activeTiles;
    int lastPrefabIndex = 0;
    bool arrivedAtCheckPoint=false;
    void Start()
    {
        activeTiles = new List<GameObject>();
       
        
        for (int i = 0; i < 12; i++)
        {
            if (i < 3)
            {
                SpawnTile(0);
            }
            else
            {
                SpawnTile();
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        //arrivedAtCheckPoint=playerTransform.gameObject.GetComponent<Movement>().inBossFight;
        //if (playerTransform.transform.position.z -safeZone> (spawnZ-amnTilesOnScreen*tileLength) && !arrivedAtCheckPoint)
        //{
         // SpawnTile();
          //DeleteTile();
        //}
        
       
        

    }
    void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        if (prefabIndex == -1)
        {
            go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;

        }
        else
        {
            go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;
        }

        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }
    void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);

    }
    int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
        {
            return 0;
        }
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}

