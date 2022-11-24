using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public GameObject door;
    public bool inArea = false;
    public float buttonPress = 3.0f;

    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            inArea = true;
        }
    }

    public void FixedUpdate()
    {
        if(inArea == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                door.SetActive(false);
            }
        }

        if (door.gameObject.activeSelf == false)
        {
            buttonPress -= Time.deltaTime;
        }

        if(buttonPress <= 0)
        {
            door.SetActive(true);

            buttonPress = 3;
        }
    }
}
