using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject Canvas;
    
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pause();
        }
    }

    private void pause()
    {
        if (Canvas.activeInHierarchy == false)
        {
            Canvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
