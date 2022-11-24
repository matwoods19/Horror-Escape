using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeDoor : MonoBehaviour {

    Text Scode;

    public GameObject door;
    public GameObject Canvas;
    public Text code;

    public void Start()
    {
        Scode = GetComponent<Text>();
    }

    public void one()
    {
        Scode.text = "1";
    }

    public void two()
    {
        Scode.text = "2";
    } 

    public void three()
    {
        Scode.text = "3";
    }

    public void four()
    {
        Scode.text = "4";
    }

    public void five()
    {
        Scode.text = "5";
    }

    public void six()
    {
        Scode.text = "6";
    }

    public void seven()
    {
        Scode.text = "7";
    }

    public void eight()
    {
        Scode.text = "8";
    }

    public void nine()
    {
        Scode.text = "9";
    }

    public void back()
    {
        Canvas.SetActive(false);
    }

    public void FixedUpdate()
    {
        Cursor.visible = true;

        if(Scode == code)
        {
            door.transform.Rotate(0, -90, 0, Space.World);

            Canvas.SetActive(false);
        }
    }
}
