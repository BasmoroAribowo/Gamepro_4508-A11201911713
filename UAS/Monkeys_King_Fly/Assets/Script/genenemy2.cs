using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genenemy2 : MonoBehaviour
{    
    GUIStyle guistyle = new GUIStyle();
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle",6f,4.5f);
    }
    void CreateObstacle()
    {
        Instantiate (enemy);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
