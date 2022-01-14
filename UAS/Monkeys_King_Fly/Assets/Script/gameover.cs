using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public Text pointsText;
    // Start is called before the first frame update
    public void setup(int score){
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void restart()
    {
        SceneManager.LoadScene("Main");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
