using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTime : MonoBehaviour {


    public void FixedUpdate()
    {
        Debug.Log("Time" + Time.timeScale);
    }
}
