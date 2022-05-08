using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AmmoManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Ammo;

    private int MaxAmmo;
    public static int CurrentAmmo;
    public GameObject YouLose;
    public GameObject Counter;
    void Start()
    {
        MaxAmmo = Ammo.Length;
        CurrentAmmo = Ammo.Length;           
    }

    // Update is called once per frame
    void Update()
    {
        //if player ammo reaches 0, start function that switches scene
         if(CurrentAmmo == 0){
            StartCoroutine(SwitchSceneWait());
        }   
    }

    
    IEnumerator SwitchSceneWait(){
        YouLose.SetActive(true);
        Counter.SetActive(false);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("LevelOne");
    }


}
