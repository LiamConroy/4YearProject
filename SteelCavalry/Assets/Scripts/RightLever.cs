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

    public bool bw;
    public bool fw;
    // public float startAngle = 0.3174578f;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        limit = hinge.limits;
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
        if(angle <= limit.min){
            bw = true;
            fw = false;

            Debug.Log("backwards" + bw);
        }

        if(angle >= limit.max){
            bw = false;
            fw = true;
            
            Debug.Log("forwards" + fw);
        }
    }
}

    
