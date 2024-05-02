using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControler : MonoBehaviour
{
    [SerializeField] Map map;
    [SerializeField] List<int> random1 = new List<int>();
    [SerializeField] int numberTile;
    List<GameObject> cube =new List<GameObject>();
    Dictionary<Vector3,GameObject> listCube
        =new();
    private void Start()
    {
        RandomList();
    }
    private void Update()
    {
        RaycatToMap();
        
    }

    void RaycatToMap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (!listCube.ContainsKey(hit.transform.position))
                {
                  var gm =  map.InstantiateCube(hit.transform.position);
                   listCube.Add(hit.transform.position, gm);
                    //vector3s.Add(hit.transform.position);
                   
                }
                else
                {
                    Destroy(listCube[hit.transform.position]);
                    listCube.Remove(hit.transform.position);
                }
                
                
                Debug.Log(hit.transform.position);

            }

        }
    }
    void RandomList()
    {
        InitList();
        random1.Shuffle();
        for(int i = 0; i < random1.Count; i++) 
        {
            map.array[i].SetText($"{random1[i]}");
        }
    }
   void InitList()
    {
        random1.Clear();
        if (map.row * map.colum % 2 != 0)
        {
            Debug.LogError("number tile must be even");
            return;
        }
        if(map.row * map.colum % numberTile != 0)
        {
            Debug.LogError("ddd");
            return;
        }
        for(int i = 0;i <(map.row*map.colum)/numberTile ;i++) 
        {
           for(int j=0;j<numberTile; j++)
            {
                random1.Add(i);
            }
        }
    }
}
