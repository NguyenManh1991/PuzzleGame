using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DictionnaryTest : MonoBehaviour
{
    [SerializeField] Dictionary<int, int> dicTest = new();
    [SerializeField] int keyTest,x,s,z;

    private void Start()
    {
        AddDic();
        CheckKey(s,z);
    }
    private void Update()
    {
        ClearDic();
        
    }
    void AddDic()
    {
        int value = 0;
        for (int i = 0; i < keyTest; i++) 
        {
           
             value+=x; 

            dicTest.Add(i, value);
            //Debug.Log(dicTest[i]);
        }
        foreach(var dicTest1 in dicTest.Values)
        {
            Debug.Log(dicTest1);
        }
        Debug.Log(dicTest.Count);
       
    }
    void ClearDic()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dicTest.Clear();
            Debug.Log(dicTest.Count);
        }
    }
    void CheckKey(int a, int b)
    {
        Debug.Log(dicTest.ContainsKey(a));
        Debug.Log(dicTest.ContainsValue(b));
        if(dicTest.ContainsKey(a))
        {
            dicTest.Remove(a);
            Debug.Log(dicTest.Count);
            for(int i = 0; i < dicTest.Count; i++)
            {
                Debug.Log(dicTest[i]);
                Debug.Log(dicTest.Values);
            }
        }
    }
}
