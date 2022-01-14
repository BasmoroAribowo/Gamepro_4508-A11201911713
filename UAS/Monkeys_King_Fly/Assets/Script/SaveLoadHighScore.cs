using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveLoadHighScore : MonoBehaviour
{
    public Text tekshighscore;
    // Start is called before the first frame update
    void Start()
    {
        tekshighscore.text = "HighScore = " + LoadHighScore().ToString();
    }

    public static int LoadHighScore()
    {
        int hg=0;
        if(!PlayerPrefs.HasKey("highscore"))
            PlayerPrefs.SetInt("highscore", 0);
        else
            hg = PlayerPrefs.GetInt("highscore");
        return hg;
    }

    public static void SaveHighScore(int score)
    {
        int hg=0;
        if(!PlayerPrefs.HasKey("highscore"))
            PlayerPrefs.SetInt("highscore", 0);
        else
            hg = PlayerPrefs.GetInt("highscore");
            hg = score;
            PlayerPrefs.SetInt("highscore", hg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
