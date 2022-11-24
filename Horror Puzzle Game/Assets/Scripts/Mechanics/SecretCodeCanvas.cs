using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretCodeCanvas : MonoBehaviour {

    public GameObject canvas;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                canvas.SetActive(true);
            }
        }
    }
}
