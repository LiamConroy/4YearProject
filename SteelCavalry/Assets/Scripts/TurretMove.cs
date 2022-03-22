using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMove : MonoBehaviour
{
    // Start is called before the first frame update
       //angle threshold to trigger if we reached limit
    public HingeJoint hinge;
    public float angle;
    public JointLimits limit;

    public JointSpring spring;

    public static bool left;
    public static bool right;

    public static bool center;

    public static bool grabbed;

    public static bool dir;

    public float centerMin = -0.1f;
    public float centerMax = 0.1f;

    public GameObject turret;

    public float rotationSpeed = 1f;

    public Rigidbody body;

    

    Vector3 currentEuler; 
    
    float x;
    float y;
    float z; 


    
    // public float startAngle = 0.3174578f;

    // Start is called before the first frame update
    void Start()
    {
        turret = GameObject.Find("TurretCenter");
        body = GetComponent<Rigidbody>();
        hinge = GetComponent<HingeJoint>();
        limit = hinge.limits;
        spring = hinge.spring;
    }

    void Update()
    {
        angle = hinge.angle;
        direction();
        turretMove();
    }

    public void direction(){

     if(!grabbed){
        if(angle > centerMin && angle < centerMax){
            // Debug.Log("center");
            center = true;
        }
     }

        if(angle >= limit.min && angle < centerMin){
            left = true;
            right = false;
            center = false;
            // Debug.Log("backwards" + bw);
        }

        if(angle <= limit.max && angle > centerMax){
            left = false;
            right = true;
            center = false;
            // Debug.Log("forwards" + fw);
        }

    }

    public void turretMove(){
        // Debug.Log("forward" + right);
        // Debug.Log("backward" + left);
        // Debug.Log("grabbed" + grabbed);
        // Debug.Log("Center" + center);
        if((right && !left) && (!center && grabbed)){
            turret.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
            // Vector3 rotationVector = new Vector3(0,rotationSpeed,0);
            // Quaternion rotation = Quaternion.Euler(rotationVector);
            // currentEuler += new Vector3(x,rotationSpeed,z) * Time.deltaTime;
            // turret.transform.eulerAngles = currentEuler;

            // Quaternion rotation = transform.rotation * Quaternion.Euler(Vector3.up * rotationSpeed);
            
            Debug.Log("Right");
        }

        if((!right && left) && (!center && grabbed)){
            turret.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime, Space.Self);

            // currentEuler -= new Vector3(x,rotationSpeed,z) * Time.deltaTime;
            // turret.transform.eulerAngles = currentEuler;

            //  Quaternion rotate = transform.rotation * Quaternion.Euler(Vector3.up * rotationSpeed);
             
            // Debug.Log("X: " + transform.position.x);
            // Debug.Log("Z: " +transform.position.z);
            Debug.Log("Left");
        }  

      return;
    }

    public void held(){
        grabbed = true;
        // Debug.Log(grabbed);
    }

    public void released(){
        grabbed = false;
        // Debug.Log(grabbed);
    }

    public void slowStart(){
        rotationSpeed = 5f;
    }

    public void slowStop(){
        rotationSpeed = 20f;
    }


}
