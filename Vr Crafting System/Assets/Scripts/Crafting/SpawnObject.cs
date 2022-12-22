using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnObject : MonoBehaviour
{
    public GameObject Thing;
    public Transform spawnPoint;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(CreateObject);
    }

    public void CreateObject(ActivateEventArgs arg)
    {
        GameObject spawnThing = Instantiate(Thing);
        spawnThing.transform.position = spawnPoint.position;
    }
}
