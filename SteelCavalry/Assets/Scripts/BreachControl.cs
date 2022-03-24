using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreachControl : MonoBehaviour
{
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

    // public GameObject BreachDoor;

    [SerializeField] private Animator BreachDoor;
    [SerializeField] private string open = "BreachDoorOpen";
    [SerializeField] private string close = "BreachDoorClose";

    float speed = 1f;

    // Start is called before the first frame update
   
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        limit = hinge.limits;
        spring = hinge.spring;
        // BreachDoor = GameObject.Find("BreachDoor");
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

            // Debug.Log("down" + bw);
            BreachDoor.Play(close, 0, 0.0f);


        //BreachDoor.transform.Translate(Mathf.Clamp(speed,-5f,6f), BreachDoor.transform);
            
            // return;
        }

        if(angle <= limit.max && angle > centerMax){
            bw = false;
            fw = true;
            center = false;
            // Debug.Log("up" + fw);

            BreachDoor.Play(open, 0, 0.0f);
            // transform.Translate(Vector3.up * Time.deltaTime, BreachDoor.transform);

            // return;
        }


    }

    public void held(){
        grabbed = true;
    }

    public void released(){
        grabbed = false;
    }
}
