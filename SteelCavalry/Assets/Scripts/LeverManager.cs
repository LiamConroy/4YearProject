using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    // public Vector3 rotation;
    public float turnSpeed;
    public static GameObject Tank;
    public float rotationSpeed = 5f;
    public float driveSpeed = 2f;

    public Rigidbody tankRB;
    // public Quaternion start;
    public GameObject Engine;
    public GameObject EngineIdle;

    Vector3 eulerVelocity;
    void Start()
    {
   
        eulerVelocity = new Vector3(0,20,0);
        // start = transform.rotation; 
    }

    // Update is called once per frame
    void Update()
    {

        
        direction();
    }

    //bools that correspond to positions of levers imported from LeftLever and RightLever scripts
    public void direction(){

        //if tank isnt moving set engine idle to active
        if((LeftLever.center && RightLever.center) && (!RightLever.grabbed && !LeftLever.grabbed)){
            Engine.SetActive(false);
            EngineIdle.SetActive(true);             
        }

        //checks if both levers are forward and not centered, if true moves forward
        if((LeftLever.fw && RightLever.fw) && (!LeftLever.center && !RightLever.center)){
            // Debug.Log("forward");
            // transform.Translate(Vector3.forward * Time.deltaTime, Tank.transform);
            Engine.SetActive(true);
            EngineIdle.SetActive(false);       
            tankRB.MovePosition(transform.position + transform.forward * Time.deltaTime * driveSpeed);
            // m_engine.Play();
            // m_engineIdle.Stop(); 
        }

        //checks if both levers are backward and not centered, if true moves backward
        if((LeftLever.bw && RightLever.bw) && (!LeftLever.center && !RightLever.center)){
            // Debug.Log("backward");
            // transform.Translate(Vector3.back * Time.deltaTime, Tank.transform);
            Engine.SetActive(true);
            EngineIdle.SetActive(false);   
            tankRB.MovePosition(transform.position - transform.forward * Time.deltaTime * driveSpeed); 
            // m_engine.Play(); 
            //  m_engineIdle.Stop(); 
            
        }

        //checks if left lever is forward and Right lever is backward and neither are centered, if true rotate right
        if((LeftLever.fw && RightLever.bw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("RightTurn");
            // Vector3 rotateVector = rotation;
            // Tank.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
            Engine.SetActive(true);
            EngineIdle.SetActive(false);   
            
            Quaternion rotation = Quaternion.Euler(eulerVelocity * Time.fixedDeltaTime);
            tankRB.MoveRotation( tankRB.rotation * rotation);
        
        }

        //checks if right lever is forward and left lever is backward and neither are centered, if true rotate left
        if((LeftLever.bw && RightLever.fw) && (!LeftLever.center && !RightLever.center)){
            Engine.SetActive(true);
            EngineIdle.SetActive(false);   
            Debug.Log("LeftTurn");
            Quaternion rotation = Quaternion.Euler(-eulerVelocity * Time.fixedDeltaTime);
            tankRB.MoveRotation( tankRB.rotation * rotation);
            // Tank.transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime, Space.Self);
            // m_engine.Play(); 
            //  m_engineIdle.Stop(); 
            
        }

        else{
            // Debug.Log("Bruh");
        }

        return;          
    }
}
