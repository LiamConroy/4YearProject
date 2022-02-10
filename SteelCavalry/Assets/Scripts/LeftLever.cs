using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftLever : MonoBehaviour
{

    //angle threshold to trigger if we reached limit
    public HingeJoint hinge;
    public float angle;
    public JointLimits limit;

    public JointSpring spring;

    public static bool bw;
    public static bool fw;

    public static bool dir;

    public float centerMin = -0.5f;
    public float centerMax = 0.5f;

    
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
        // Debug.Log("Start");
        // angle();
        
        angle = hinge.angle;
        // Debug.Log(limit.min);
        // Debug.Log(angle);
        direction();
     
    }

    public void direction(){
        if(angle >= limit.min && angle < centerMin){
            bw = true;
            fw = false;
            // Debug.Log("backwards" + bw);
        }

        if(angle >= limit.max){
            bw = false;
            fw = true;
            // Debug.Log("forwards" + fw);
        }

        if(angle >= centerMin && angle <= centerMax){
            Debug.Log("center");
        }
    }

    public void angleReset(){
        spring.targetPosition = 0;
        // Debug.Log("reset");
    }
}

    
