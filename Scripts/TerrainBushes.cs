using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBushes : MonoBehaviour
{
    public GameObject[] bushes;
    public Terrain terrain;
    void Start()
    {
        PlaceBushes();
    }

    void PlaceBushes()
    {
        TerrainData terraindata = terrain.terrainData;
        int bushSpacing = 5;
        for (int x=0; x<terraindata.size.x; x +=bushSpacing)
        { 
            for(int z = 0; z < terraindata.size.z; z += bushSpacing)
            {
                Vector3 pos = new Vector3(x, 0, z);
                pos.y = terrain.SampleHeight(pos);
                int i = Random.Range(0, bushes.Length);
                Instantiate(bushes[i], pos, Quaternion.identity);
            }
        }
    }
}
