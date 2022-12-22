using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopBlock : MonoBehaviour
    {
        public GameObject CraftedItem;
        public string TagOfObject = "";
        public Transform BaseLocation;
        private int i;
        public int SpawnHowMany;
        public void Create()
        { 
            for (int z = 0; z < SpawnHowMany; z++)
           {
            GameObject SpawnSecondThing = Instantiate(CraftedItem);
            SpawnSecondThing.transform.position = BaseLocation.position;
            }
        }
    private void OnTriggerEnter(Collider other)
        {
            if (other.tag == TagOfObject)
            {
                i++;
                if (i == 3)
                {
                    Destroy(gameObject);
                    Create();
                }
            }
        }
}

