using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundDetection : MonoBehaviour
{

    public static GameObject shell;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnCollisionEnter
    void OnTriggerEnter(Collider other){
        if (other.transform.CompareTag("Loaded")){
        // Debug.Log(other.gameObject.name + " Shell is loaded");
        shell = GameObject.Find(other.gameObject.name);
        Debug.Log(shell.gameObject.tag);
        Debug.Log("shell is loaded");
        }

        if(other.transform.CompareTag("Spent")){
            // Debug.Log("shell is spent");
            shell = GameObject.Find(other.gameObject.name);
            Debug.Log("shell spent");

        }

    }
}
