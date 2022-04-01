using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    
    public GameObject pageOne;
    public GameObject pageTwo;
    public GameObject pageThree;

    public Collider back;
    public Collider next;

    public int pageCount;
    // Start is called before the first frame update
    void start(){
        pageCount = 1;
    }

    void OnTriggerEnter(Collider back){
        if(back.transform.CompareTag("GameController")){
            Debug.Log("Back!");
        }

        // if(other.transform.CompareTag("GameController")){
        //     Debug.Log("Next!");
        // }
    }
    


}
