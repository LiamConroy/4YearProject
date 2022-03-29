using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject projectile;

    public GameObject explosion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.transform.CompareTag("Enemy")){
            Debug.Log("Hit");
            Destroy(projectile);      

        }

        if (other.transform.CompareTag("Ground")){
            explosion.SetActive(true);
        }

    }
}
