using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start0()
    {
        SceneManager.LoadScene("Guri de carpete");
    }
    public void Start1()
    {
        SceneManager.LoadScene("Bagual");
    }
    public void Start2()
    {
        SceneManager.LoadScene("Peleia braba");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
