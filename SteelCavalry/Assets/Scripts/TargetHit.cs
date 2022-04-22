
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject projectile;

    public GameObject explosion;

    public GameObject enemyHitExp;
    private GameObject Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator OnTriggerEnter(Collider other){
         projectile.GetComponent<Rigidbody>().velocity = Vector3.zero;
         projectile.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; 
        if (other.transform.CompareTag("Enemy")){
            Debug.Log("Hit");
            enemyHitExp.SetActive(true);
            yield return new WaitForSeconds(0.01f);
            Destroy(projectile);
            // Enemy = GameObject.Find(other.gameObject.name);   
        }

        if (other.transform.CompareTag("Ground")){
            explosion.SetActive(true);
            yield return new WaitForSeconds(0.05f);
            Debug.Log("Ground Hit");
            Destroy(projectile);
        }

        else{
            enemyHitExp.SetActive(true);
            yield return new WaitForSeconds(0.05f);
            Destroy(projectile);
        }

    }

    
}
