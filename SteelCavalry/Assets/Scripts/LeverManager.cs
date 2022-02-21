using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    // public Vector3 rotation;
    public float turnSpeed;
    public GameObject Tank;
    void Start()
    {
        //  Lf = FindObjectOfType<LeftLever>();
        //  Rf = FindObjectOfType<RightLever>();    
        Tank = GameObject.Find("TankProto");
    }

    // Update is called once per frame
    void Update()
    {

        //  Vector3 bruh = new Vector3(x, 0f, z); 
        direction();

    }

    public void direction(){

        if((LeftLever.center && RightLever.center) && (!RightLever.grabbed && !LeftLever.grabbed)){
           
        }

        if((LeftLever.fw && RightLever.fw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("forward");
            transform.Translate(Vector3.forward * Time.deltaTime, Tank.transform);
        }

        if((LeftLever.bw && RightLever.bw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("backward");
            transform.Translate(Vector3.back * Time.deltaTime, Tank.transform);
        }

        if((LeftLever.fw && RightLever.bw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("RightTurn");
            // Vector3 rotateVector = rotation;
            // transform.Rotate(rotation * Time.deltaTime);
        }

        if((LeftLever.bw && RightLever.fw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("LeftTurn");
        }

        // else if(LeftLever.bw && RightLever.fw){
        //     Debug.Log("left");
        // }

        // else if(LeftLever.fw && RightLever.bw){
        //     Debug.Log("right");
        // }

        else{
            // Debug.Log("Bruh");
        }

        return;          
    }
}
