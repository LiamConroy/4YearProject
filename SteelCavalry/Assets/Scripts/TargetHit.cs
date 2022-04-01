using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject projectile;

    public GameObject explosion;

    public GameObject enemyHitExp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator OnTriggerEnter(Collider other){
        if (other.transform.CompareTag("Enemy")){
            Debug.Log("Hit");
            projectile.GetComponent<Rigidbody>().velocity = Vector3.zero;
            projectile.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            // enemyHitExp.SetActive(true);

            yield return new WaitForSeconds(1);
            // Destroy(projectile);      

        }

        if (other.transform.CompareTag("Ground")){
            // explosion.SetActive(true);
            // yield return new WaitForSeconds(1);
            Debug.Log("Ground Hit");
            // Destroy(projectile);
        }

    }

    
}
