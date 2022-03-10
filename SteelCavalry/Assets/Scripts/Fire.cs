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

    if((Maingun.ammoLoaded) && (BreachControl.fw && !BreachControl.bw)){
        if (other.transform.CompareTag("GameController") && (!fired)){
        Debug.Log("Pew");
        fired = true;
        }
    }
    }
}
