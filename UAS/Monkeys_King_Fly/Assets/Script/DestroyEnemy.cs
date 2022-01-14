using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemyTag")
        {
            Destroy(col.gameObject);
        }
        if (col.tag == "petirTag")
        {
            Destroy(col.gameObject);
        }
        else{}
    }
}
