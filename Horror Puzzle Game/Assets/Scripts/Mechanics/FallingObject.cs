using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour {

    public GameObject painting;

    public bool InArea = false;

    public void Start()
    {
        painting.GetComponent<Rigidbody>().useGravity = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            InArea = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Plyaer")
        {
            InArea = false;
        }
    }

    public void FixedUpdate()
    {
        if(InArea == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                painting.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
