using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopTimer : MonoBehaviour
{
    public GameObject time;

    private void OnTriggerStay(Collider other)
    {
        time = GameObject.Find("Timer");

        if (other.GetComponent<Collider>().tag == "Player")
        {
            time.GetComponent<DeathTimer>().timelimit += Time.deltaTime;
        }
    }
}
