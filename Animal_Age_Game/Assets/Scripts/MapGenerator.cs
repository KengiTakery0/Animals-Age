using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] int size = 100;
    
    [Range(0.00f,0.5f)][SerializeField] float scale = .1f;
    [SerializeField] Tile waterTile;
    [SerializeField] Tile sandTile;
    [SerializeField] Tile gTile;
    [SerializeField] Tilemap waterTilemap;
    [SerializeField] Tilemap sandTilemap;
    [SerializeField] Tilemap gTilemap;
    float _vateLevel = .4f;
    float _sandLevel = .45f;
    float _gLevel = .55f;
    void Start()
    {
        float[,] noiseMap = new float[size, size];
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                float noise = Mathf.PerlinNoise(x*scale, y*scale);
                noiseMap[x, y] = noise;
            }
        }
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                Vector3Int pos = new Vector3Int(x, y,0);
                float noseval = noiseMap[x, y];
               
                if (noseval < _vateLevel) waterTilemap.SetTile(pos, waterTile);
                else if(noseval <_sandLevel) sandTilemap.SetTile(pos, sandTile);
                else gTilemap.SetTile(pos, gTile);
            }
        }
    }
}
