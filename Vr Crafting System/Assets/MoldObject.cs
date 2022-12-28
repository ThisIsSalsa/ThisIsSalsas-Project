using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoldObject : MonoBehaviour
{
    public GameObject makeObject;
    public Transform spawnPoint;
    public string Name;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Name)
        {
                Destroy(gameObject);
                Destroy(other.gameObject);
            GameObject spawnThing = Instantiate(makeObject);
                spawnThing.transform.position = spawnPoint.position;
        }
    }

}
