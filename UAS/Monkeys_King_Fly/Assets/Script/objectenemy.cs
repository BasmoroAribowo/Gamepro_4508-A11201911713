using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectenemy : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-10,0);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        float range = 6;
        transform.position = new Vector3 (transform.position.x, transform.position.y - range * Random.value, 
                                        transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
