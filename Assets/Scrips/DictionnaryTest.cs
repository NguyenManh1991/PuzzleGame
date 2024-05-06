using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class DictionnaryTest : MonoBehaviour
{
    [SerializeField] Dictionary<int, int> dicTest = new();
    [SerializeField] int keyTest, x, s, z;
    [SerializeField] Dictionary<Vector3, GameObject> dicTest2 = new();
    [SerializeField] GameObject instance, instance1,instance2;
    Vector3 positionInstace;
    [SerializeField] float velocity = 2f;
    private void Start()
    {
        //AddDic();
        // CheckKey(s, z);
        Instantiate();
        checkDictest2();
        RandomFood();
    }
    private void Update()
    {
        //ClearDic();
        MoveInstance();

    }
    void AddDic()
    {
        int value = 0;
        for (int i = 0; i < keyTest; i++)
        {

            value += x;

            dicTest.Add(i, value);
            //Debug.Log(dicTest[i]);
        }
        foreach (var dicTest1 in dicTest.Values)
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
        if (dicTest.ContainsKey(a))
        {
            dicTest.Remove(a);
            Debug.Log(dicTest.Count);
            foreach (var dicTest1 in dicTest.Values)
            {
                Debug.Log(dicTest1);
            }

        }
    }

    private void Instantiate()
    {

        int count = 0;
        for (int i = 1; i <= keyTest; i++)
        {
            for (int j = 1; j <= keyTest; j++)
            {
                var test2 = Instantiate(instance1);
                var position2 = test2.transform.localPosition = new Vector3(i, j, 0);
                //test2.transform.SetParent(transform, false);
                if (i == 1 && j == 1)
                {
                    instance = Instantiate(this.instance);
                    positionInstace = instance.transform.localPosition = new Vector3(i, j, 0);
                    //instance.transform.SetParent(transform, false);
                    instance.name = "v" + count++;
                    dicTest2.Add(positionInstace, instance);
                }
            }
        }
    }
    private void checkDictest2()
    {
        foreach (var dicTest in dicTest2)
        {
            Debug.Log(dicTest);
        }
    }

    private void MoveInstance()
    {
        var move = instance.transform.position;
        instance.name = "Cube";
        if (Input.GetKey(KeyCode.W))
        {
            if (move.y >= keyTest)
            {
                return;
            }
            else move += Vector3.up * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (move.y <= 1) { return; }
            else move += Vector3.down * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (move.x <= 1) { return; }
            else move += Vector3.left * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (move.x >= keyTest) { return; }
            else move += Vector3.right * velocity * Time.deltaTime;
        }
        instance.transform.position = move;
    }
    private void RandomFood()
    {
        instance2 = Instantiate(instance2);
        instance2.name = "Test";
        int positionX = Random.Range(1, keyTest);
        int positionY = Random.Range(1, keyTest);
        instance2.transform.position=new Vector3(positionX, positionY, 0);
        
    }
    public void SetParent()
    {
        Destroy(instance2 );
    }
}
