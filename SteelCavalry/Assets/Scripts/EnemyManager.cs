using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] Enemys;
    private int EnemyCountMax;
    public static int CurrentEnemyCount;

    public TMP_Text Current;
    public TMP_Text Max;
    public GameObject Counter;
    public GameObject YouWin;
    void Start()
    {
        EnemyCountMax = Enemys.Length;
        CurrentEnemyCount = Enemys.Length;
        Max.text = EnemyCountMax.ToString();  
    }

    // Update is called once per frame
    void Update()
    {          
        // Debug.Log(CurrentEnemyCount+"/"+EnemyCountMax);
        Current.text = CurrentEnemyCount.ToString();
        // SwitchSceneWait();
        if(CurrentEnemyCount == 0){
            StartCoroutine(SwitchSceneWait());
        }
    }


    IEnumerator SwitchSceneWait(){
        Counter.SetActive(false);
        YouWin.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu");
    }
    

}
