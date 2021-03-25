using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
   [SerializeField] private int maxTerrainCount;
   private List<GameObject> currentTerrains = new List<GameObject>();
   [SerializeField] private Transform terrainHolder;
   [SerializeField] int distanceFromPlayer;
   public MoveChar characterPos;
 
    [SerializeField] private List<TerrainData> TerrainDatas = new List<TerrainData>();
 
    [HideInInspector]  Vector3 currentPos = new Vector3(0, 0, 0);

    public void Start()
    {
        
        for (int i = 0; i < maxTerrainCount; i++)
        {
            CreateTerrain(true,new Vector3(i,0,0));
        }
        maxTerrainCount = currentTerrains.Count;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CreateTerrain(false, characterPos.transform.position);
        }
    }

    public void CreateTerrain(bool isStart,Vector3 playerPos)
    {
        {
            int fromterrain = Random.Range(0, TerrainDatas.Count);
            int terrainInRow = Random.Range(1, TerrainDatas[fromterrain].maxInRow);

            if(currentPos.x-playerPos.x<distanceFromPlayer)
            {
                for (int i = 0; i < terrainInRow; i++)
                {  
                    GameObject terrain = Instantiate(TerrainDatas[fromterrain].terrain, currentPos, Quaternion.identity, terrainHolder);
                    currentTerrains.Add(terrain);

                    if (!isStart)
                    {
                        if (currentTerrains.Count > maxTerrainCount)
                        {
                            Destroy(currentTerrains[0]);
                            currentTerrains.RemoveAt(0);
                        }
                    }
                    currentPos.x++;
                }
            }
        }
    }
}

 
