using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDetacher : MonoBehaviour
{
    private Transform can;
    private GameObject parent;
    
    private void Start()
    {
        can = GetComponent<Transform>();
        parent = GameObject.Find("Fridge Openned");
    }
    void Update()
    {
        if (can.transform.position.x > -1.9f || can.transform.position.x < -3.1f || can.transform.position.y > -0.8f || can.transform.position.y < -2.1f)
        {
            can.transform.parent = null;
        }
        else
        {
            
            can.transform.SetParent(parent.transform);
        }
    }
}
