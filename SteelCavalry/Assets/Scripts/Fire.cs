using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){

        if (other.transform.CompareTag("XR Origin")){
        Debug.Log("Pew");
        }
    }
}
