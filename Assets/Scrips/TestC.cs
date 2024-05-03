using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestC : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] List<GameObject> testList = new();
    [SerializeField] int testIndex = 0;
    [SerializeField] List<int> ints =new List<int>{1,3,9,2,5,4,6,7};
    private void Start()
    {
        AddValueToList();
        Arrange();
    }
    private void Update()
    {
        ClearList();
        
    }
    void AddValueToList()
    {

        int count = 0;
        for (int i = 0; i < testIndex; i++) 
        {
            
            var cube1 = Instantiate(cube);
            cube1.name = "cube" + count++;
            testList.Add(cube1);
            //cube.transform.SetParent(transform, false);
            cube.transform.localPosition += Vector3.up;
            

        }
        CheckList();
        
    }
    void CheckList()
    {
        for(int i = 0;i < testList.Count;i++) 
        {
            Debug.Log(testList[i]);
        }
    }
    void ClearList()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            testList.Clear();
            Debug.Log(testList.Count);
        }
        if (Input.GetMouseButtonDown(1))
        {
            testList.Reverse();
            
        }
    }
    void Arrange()
    {
        ints.Sort();
    }


}
