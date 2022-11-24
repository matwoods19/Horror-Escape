using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

    public bool InArea = false;
    public GameObject player;
    public Transform elevator;
    public Vector3 NewPosition;
    Vector3 move = new Vector3(0, .1f, 0);

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            InArea = true;

            player.transform.SetParent(elevator);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            InArea = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (InArea == false)
        {
            player.transform.SetParent(null);
        }

        if (other.GetComponent<Collider>().tag == "Player")
        {
            if (InArea == true)
            {
                player.transform.SetParent(elevator);

                if (elevator.transform.position != NewPosition)
                {
                    elevator.transform.position += move;

                    //Debug.Log("new elevator position: " + elevator.transform.position);
                }

                if (elevator.transform.position.y >= NewPosition.y)
                {
                    elevator.transform.position = NewPosition;
                }
            }
        }
    }
}


