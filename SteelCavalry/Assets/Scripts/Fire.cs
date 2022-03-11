using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject XROrigin;
    public static bool fired;

    void Start(){
        XROrigin = GameObject.Find("XR Origin");
    }
    
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other){

    if((Maingun.ammoLoaded && RoundDetection.shell.transform.CompareTag("Loaded")) && (BreachControl.fw && !BreachControl.bw)){
        if (other.transform.CompareTag("GameController") && (!fired)){
        Debug.Log("Pew");
        fired = true;
        // RoundDetection.shell = RoundDetection.shell.gameObject.tag = "Spent";
        RoundDetection.shell.gameObject.tag = "Spent";
        }
    }
    }
}
