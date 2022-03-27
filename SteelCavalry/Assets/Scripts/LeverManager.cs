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
    public AudioSource m_engine;
    public AudioSource m_engineIdle;

    Vector3 eulerVelocity;
    void Start()
    {
        //  Lf = FindObjectOfType<LeftLever>();
        //  Rf = FindObjectOfType<RightLever>();    
        // tankRB = GetComponent<Rigidbody>(); 
        eulerVelocity = new Vector3(0,20,0);

        
        // start = transform.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {

        // m_engineIdle.Play();
        direction();
    }

    public void direction(){

        if((LeftLever.center && RightLever.center) && (!RightLever.grabbed && !LeftLever.grabbed)){
            
        }

        if((LeftLever.fw && RightLever.fw) && (!LeftLever.center && !RightLever.center)){
            // Debug.Log("forward");
            // transform.Translate(Vector3.forward * Time.deltaTime, Tank.transform);
            tankRB.MovePosition(transform.position + transform.forward * Time.deltaTime * driveSpeed);
            // m_engine.Play();
            // m_engineIdle.Stop(); 
        }

        if((LeftLever.bw && RightLever.bw) && (!LeftLever.center && !RightLever.center)){
            // Debug.Log("backward");
            // transform.Translate(Vector3.back * Time.deltaTime, Tank.transform);
            tankRB.MovePosition(transform.position - transform.forward * Time.deltaTime * driveSpeed); 
            // m_engine.Play(); 
            //  m_engineIdle.Stop(); 
            
        }

        if((LeftLever.fw && RightLever.bw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("RightTurn");
            // Vector3 rotateVector = rotation;
            // Tank.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
            
            Quaternion rotation = Quaternion.Euler(eulerVelocity * Time.fixedDeltaTime);
            tankRB.MoveRotation( tankRB.rotation * rotation);
            // m_engine.Play(); 
            //  m_engineIdle.Stop(); 
            // transform.RotateAround(Tank.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if((LeftLever.bw && RightLever.fw) && (!LeftLever.center && !RightLever.center)){
            Debug.Log("LeftTurn");
            Quaternion rotation = Quaternion.Euler(-eulerVelocity * Time.fixedDeltaTime);
            tankRB.MoveRotation( tankRB.rotation * rotation);
            // Tank.transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime, Space.Self);
            // m_engine.Play(); 
            //  m_engineIdle.Stop(); 
            
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
