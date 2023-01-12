using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHouse : MonoBehaviour
{
    //add a component that checks if it fits to it insted of Tag
    bool SaveMe = false;
    public Material material;
    public Material finishedMaterial;
    public string materialMadeOf;
    public List<GameObject> list = new List<GameObject>();
    private int componentNumber = 0;
    private int componentCount;
    public void isItDone()
    {
        if (componentCount <= componentNumber)
        {
            GetComponent<Collider>().enabled = false;
            transform.parent.GetComponent<makeme>().MakeCurentChild();
            Debug.Log("Its done");
        }
    }
    void Start()
    {
        List<Transform> children = GetChildren(transform);
        foreach (Transform child in children)
        {
            componentCount++;
        }
    }
    List<Transform> GetChildren(Transform parent)
    {
        List<Transform> children = new List<Transform>();
        foreach (Transform child in parent)
        {
            children.Add(child);
        }
        return children;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == materialMadeOf)
        {
            Destroy(other.gameObject);
            list[componentNumber].GetComponent<MeshRenderer>().material = material;
            componentNumber++;
            isItDone();
        }
    }
}