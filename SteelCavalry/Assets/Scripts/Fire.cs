using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject XROrigin;
    public static bool fired;
    public Transform muzzle;
    public GameObject shell;
    float x;
    float y;
    float z;

    public float projectileSpeed = 10f;


    void Start(){
        XROrigin = GameObject.Find("XR Origin");
    }
    
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other){

    if((Maingun.ammoLoaded && RoundDetection.shell.transform.CompareTag("Loaded")) && (BreachControl.fw && !BreachControl.bw)){
        if (other.transform.CompareTag("GameController") && (!fired)){
        Debug.Log("Pew");
        GameObject currentShell = Instantiate(shell, muzzle.position, gameObject.transform.rotation);
        currentShell.transform.Rotate(new Vector3(90,0,0));

        currentShell.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed,ForceMode.Impulse);

        fired = true;
        // RoundDetection.shell = RoundDetection.shell.gameObject.tag = "Spent";
        RoundDetection.shell.gameObject.tag = "Spent";
        }
    }
    }
}
