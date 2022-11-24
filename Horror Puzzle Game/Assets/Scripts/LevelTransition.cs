using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour {

    public string index;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(index);
        }
    }
}
