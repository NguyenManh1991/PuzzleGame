using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject prefab, cubePrefab;
    [SerializeField] int row,colum;
    GameObject[,] array;
    private void Start()
    {
        InstantiateMap();
        //InstantiateCube();
    }

    void InstantiateMap()
    {
        array = new GameObject[row,colum];
        for(int i = 0; i < row; i++)
        {
            for (int j = 0; j < colum; j++)
            {
                array[i, j] = Instantiate(prefab);
                array[i, j].transform.localPosition = new Vector3(i, j, 0);
                array[i,j].transform.SetParent(transform);
            }
        }
    }

    public  void InstantiateCube(Vector3 position)
    {
        
        var cube = Instantiate(cubePrefab);
        cube.transform.localPosition = position;
        cube.transform.SetParent(transform);
        
    }
}
