using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codetombol : MonoBehaviour
{

    public void OnPlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void OnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void OnBack()
    {
        SceneManager.LoadScene("Menu");
    }

}

