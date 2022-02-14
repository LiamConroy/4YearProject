using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{

    // public LeftLever Lf;
    // public RightLever Rf;
    // Start is called before the first frame update

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
        direction();
    }

    public void direction(){

        if(LeftLever.center == RightLever.center){
            Debug.Log("center");
        }

        if(LeftLever.fw == RightLever.fw){
            Debug.Log("forward");
            
        }

        if(!LeftLever.bw == RightLever.bw){
            Debug.Log("backward");
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
    }
}
