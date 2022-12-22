using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Smash : MonoBehaviour
{
    public GameObject Destroyed;
    public GameObject CraftedItem;
    public string TagOfObject = "";
    public Transform BaseLocation;
    private int i;
  
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == TagOfObject)
        {
            i++;
            if (i == 3)
            {


                Destroy(gameObject);
                GameObject spawnThing = Instantiate(Destroyed);
                spawnThing.transform.position = BaseLocation.position;

                GameObject SpawnSecondThing = Instantiate(CraftedItem);
                SpawnSecondThing.transform.position = BaseLocation.position;

            }
        }
    }
}