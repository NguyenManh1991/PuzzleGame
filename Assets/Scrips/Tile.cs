using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] TextMeshPro cubeNumber;

    public void SetText(string text)
    {
        cubeNumber.text = text;
    }
}
