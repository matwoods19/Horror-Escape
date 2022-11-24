using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDoor : MonoBehaviour {

    public float maxDistance;

    public GameObject fallingDoor;

    public void Start()
    {
        fallingDoor.GetComponent<Rigidbody>().useGravity = false;
    }

    void Update ()
    {
        int LayerMask = 1 << 8;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, maxDistance, LayerMask))
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            fallingDoor.GetComponent<Rigidbody>().useGravity = true;

            GetComponent<AudioSource>().Play();
        }
	}
}
