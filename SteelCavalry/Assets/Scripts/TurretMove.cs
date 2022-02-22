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

    public static bool bw;
    public static bool fw;

    public static bool center;

    public static bool grabbed;

    public static bool dir;

    public float centerMin = -0.1f;
    public float centerMax = 0.1f;

    public GameObject turret;

    public float rotationSpeed = 50f;


    
    // public float startAngle = 0.3174578f;

    // Start is called before the first frame update
    void Start()
    {
        turret = GameObject.Find("TurretCenter");
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
            bw = true;
            fw = false;
            center = false;
            Debug.Log("backwards" + bw);
        }

        if(angle <= limit.max && angle > centerMax){
            bw = false;
            fw = true;
            center = false;
            Debug.Log("forwards" + fw);
        }

    }

    public void turretMove(){
        if((fw && !bw)){
            turret.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
        }

        if((!fw && bw)){
            turret.transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime, Space.Self);
        }      
    }

    public void held(){
        grabbed = true;
    }

    public void released(){
        grabbed = false;
    }
}
