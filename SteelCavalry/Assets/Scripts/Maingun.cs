using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maingun : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool ammoLoaded;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loaded(){
    
        ammoLoaded = true;
        Fire.fired = false;
        Debug.Log(ammoLoaded);
        Debug.Log("fired: " + Fire.fired);
        // Fire.muzzleFlash.SetActive(false);
    }

    public void unloaded(){
        ammoLoaded = false;
        Debug.Log(ammoLoaded);
    }
}
