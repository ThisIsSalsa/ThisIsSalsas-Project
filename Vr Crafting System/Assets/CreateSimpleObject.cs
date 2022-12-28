using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CreateSimpleObject : MonoBehaviour
{
    public GameObject makeObject;
    public GameObject Ring;
    public Transform spawnPoint;
    public string Name;
    public string Name2;
    private int count;
    private int random = 4;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(MakeRing);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Name || other.name == Name2)
        {
            count++;
            HitCount();
        }
    }

    public void MakeRing(ActivateEventArgs arg)
    {
        
        GameObject spawnThing = Instantiate(Ring);
        spawnThing.transform.position = spawnPoint.position;
        Destroy(gameObject);
    }
    private void HitCount()
    {
        if (count >= random)
        {
            Destroy(gameObject);
            GameObject spawnThing = Instantiate(makeObject);
            spawnThing.transform.position = spawnPoint.position;
        }
    }
}
