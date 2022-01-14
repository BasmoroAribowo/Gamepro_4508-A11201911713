using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectMovement : MonoBehaviour
{
    public int nyawa = 3;
    public int score;
    public gameover gameover;
    public float speed = 3;
    GUIStyle guistyle = new GUIStyle();
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        maju = new Vector3(0, 0, 1);
        mundur = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);

        if (Input.GetKey("left"))
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);

        if (Input.GetKey("up"))
            transform.position = transform.position + (keatas * speed * Time.deltaTime);

        if (Input.GetKey("down"))
            transform.position = transform.position + (kebawah * speed * Time.deltaTime);
    }

    static Quaternion toQuaternion(Vector3 euler)
    {
        Quaternion q;
        float pitch = euler.x;
        float roll = euler.y;
        float yaw = euler.z;
        float t0 = Mathf.Cos(yaw * 0.5f);
        float t1 = Mathf.Sin(yaw * 0.5f);
        float t2 = Mathf.Cos(roll * 0.5f);
        float t3 = Mathf.Sin(roll * 0.5f);
        float t4 = Mathf.Cos(pitch * 0.5f);
        float t5 = Mathf.Sin(pitch * 0.5f);
        Debug.Log (t0 +" "+ t1+" " + t2 +" " + t3+" " + t4+" " + t5+" ");

        q.x = t0 * t3 * t4 - t1 * t2 * t5;
        q.y = t0 * t2 * t5 + t1 * t3 * t4;
        q.z = t1 * t2 * t4 - t0 * t3 * t5;
        q.w = t0 * t2 * t4 + t1 * t3 * t5;
        return q;
    }

    void Die()
    {
        gameover.setup(score);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "tanganTag"){
            nyawa--;
            if(nyawa==0){
                Die();
            }
            else{  
            } 
        }
        if (coll.gameObject.tag == "enemyTag"){
            nyawa--;
            if(nyawa==0){
                Die();
            }
            else{  
            } 
        }
        if (coll.gameObject.tag == "petirTag"){
            nyawa--;
            if(nyawa==0){
                Die();
            }
            else{  
            } 
        }
    }
    void OnGUI()
    {
        GUI.color = Color.black;
        guistyle.fontSize = 20;
        GUI.Label(new Rect(500, 0, 300, 500), "Nyawa: " + nyawa.ToString(), guistyle);
    }



}