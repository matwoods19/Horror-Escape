using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMechanics : MonoBehaviour {

    public GameObject canvas;

    public void Continue()
    {
        Time.timeScale = 1;

        canvas.SetActive(false);
    }

    public void Menu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
