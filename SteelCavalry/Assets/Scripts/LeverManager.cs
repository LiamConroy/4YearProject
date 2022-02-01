using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{

    public LeftLever Lf;
    public RightLever Rf;
    // Start is called before the first frame update
    void Start()
    {
        //  Lf = FindObjectOfType<LeftLever>();
        //  Rf = FindObjectOfType<RightLever>();    
    }

    // Update is called once per frame
    void Update()
    {
        direction();
    }

    public void direction(){
        if(Lf.fw == Rf.fw){
            Debug.Log("forward");
        }

        else if(Lf.bw == Rf.bw){
            Debug.Log("backward");
        }

        else if(Lf.bw && Rf.fw){
            Debug.Log("left");
        }

        else if(Lf.fw && Rf.bw){
            Debug.Log("right");
        }          
    }
}
