using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] Tile prefab;
    [SerializeField] GameObject cubePrefab;
    [SerializeField] public int row, colum;
    public List<Tile> array = new();
    private void Start()
    {
        InstantiateMap();
        //InstantiateCube();
    }
    
    void InstantiateMap()
    {

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                var tile = Instantiate(prefab);

                tile.transform.localPosition = new Vector3(i, j, 0);
                tile.transform.SetParent(transform);
                array.Add(tile);
            }
        }
    }

    public GameObject InstantiateCube(Vector3 position)
    {

        var cube = Instantiate(cubePrefab);
        cube.transform.localPosition = position;
        cube.transform.SetParent(transform);
        return cube;
        
    }
}
