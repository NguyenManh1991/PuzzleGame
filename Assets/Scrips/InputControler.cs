using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControler : MonoBehaviour
{
    [SerializeField] Map map;
    List<Vector3> vector3s = new List<Vector3>();
    private void Start()
    {
        
    }
    private void Update()
    {
        RaycatToMap();
        CheckList();
    }

    void RaycatToMap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (!vector3s.Contains(hit.transform.position))
                {
                    map.InstantiateCube(hit.transform.position);
                    vector3s.Add(hit.transform.position);
                   
                }
                else return;
                Debug.Log(hit.transform.position);

            }

        }
    }

    void CheckList()
    {
        
    }
}
