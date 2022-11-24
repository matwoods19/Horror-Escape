using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {

    public GameObject door;
    public bool Open = false;

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Key pressed");
                if(Open == false)
                {
                    door.transform.Rotate(0, -90, 0, Space.World);

                    Open = true;
                }
            }
        }
    }
}
