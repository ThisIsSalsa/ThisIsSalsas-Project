using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeme : MonoBehaviour
{
    //make a counter that sets all transperatnt exept the one im building
    private int CountChild;
    private int CurentChild = 0;
    void Start()
    {
        CountChild = transform.childCount;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        transform.GetChild(0).gameObject.SetActive(true);
    }
     public void MakeCurentChild()
    {
        CurentChild++;
        transform.GetChild(CurentChild).gameObject.SetActive(true);
    }
}