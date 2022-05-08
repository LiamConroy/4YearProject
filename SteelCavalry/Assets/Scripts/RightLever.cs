using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RightLever : MonoBehaviour
{

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


    
    // public float startAngle = 0.3174578f;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        limit = hinge.limits;
        spring = hinge.spring;
    }

    void Update()
    {
        
        angle = hinge.angle;
        // Debug.Log(limit.min);
        // Debug.Log(angle);
        direction();
     
    }

    public void direction(){

    //fw,bw and center bools are all checked in levermanager to determine tank direction
    //checks if the lever isnt being grabbed, if true and angle is centered, set center to true
     if(!grabbed){
        if(angle > centerMin && angle < centerMax){
            // Debug.Log("center");
            center = true;
        }
     }
        //checks if lever is backwards
        if(angle >= limit.min && angle < centerMin){
            bw = true;
            fw = false;
            center = false;
            // Debug.Log("backwards" + bw);

        }
        //checks if lever is forwards
        if(angle <= limit.max && angle > centerMax){
            bw = false;
            fw = true;
            center = false;
            // Debug.Log("forwards" + fw);
        }


    }

    //function is triggered when lever is grabbed and held
    public void held(){
        grabbed = true;
    }
    //fucntion is triggered when lever is released
    public void released(){
        grabbed = false;
    }
}

    
