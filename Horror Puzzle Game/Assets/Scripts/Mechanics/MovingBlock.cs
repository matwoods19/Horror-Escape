using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {

    public bool inArea;

    public GameObject Box;
    public Transform player;

    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            inArea = true;   
        }
    }

    public void FixedUpdate()
    {
        if (inArea == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Box.transform.SetParent(player);
            }

            if (Input.GetKeyUp(KeyCode.F))
            {
                Box.transform.SetParent(null);
            }
        }
    }
}
