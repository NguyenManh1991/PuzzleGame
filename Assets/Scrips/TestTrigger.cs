using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    DictionnaryTest test;
    private void OnTriggerEnter(Collider other)
    {
        test.SetParent(); 
      Debug.Log("s");
    }
}
