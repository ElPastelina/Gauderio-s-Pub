using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start1()
    {
        SceneManager.LoadScene("Bagual");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
