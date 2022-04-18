using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject fireFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        Debug.Log("Ive been hit");
        fireFX.SetActive(true);
        EnemyManager.CurrentEnemyCount--;   
        GetComponent<Collider>().enabled = false;
    }
}
