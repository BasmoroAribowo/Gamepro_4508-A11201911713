using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorObs : MonoBehaviour
{
    public int score = 0;
    GUIStyle guistyle = new GUIStyle();
    public GameObject rocks;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle",4f,4.5f);
    }
    void CreateObstacle()
    {
        Instantiate (rocks);
        score++;
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUI.color = Color.black;
        guistyle.fontSize = 20;
        GUI.Label(new Rect(0, 0, 300, 50), "Score: " + score.ToString(), guistyle);
    }

}
