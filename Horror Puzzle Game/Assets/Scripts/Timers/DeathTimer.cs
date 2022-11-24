using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeathTimer : MonoBehaviour {

    Text time;

    public GameObject Player;
    public GameObject Canvas;
    public GameObject Camera;
    public float timelimit = 10;

    public void Start()
    {
        time = GetComponent<Text>();
    }

    public void FixedUpdate()
    {
        timelimit -= Time.deltaTime;
        time.text = "Time: " + timelimit;

        if(timelimit <= 0)
        {
            Destroy(Player);
            Canvas.SetActive(true);
            Camera.SetActive(true);
        }
    }
}
