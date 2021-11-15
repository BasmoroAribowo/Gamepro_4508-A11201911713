using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorenemyy : MonoBehaviour
{    
    GUIStyle guistyle = new GUIStyle();
    public GameObject awan;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle",4f,4.5f);
    }
    void CreateObstacle()
    {
        Instantiate (awan);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
