using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] Enemys;
    private int EnemyCountMax;
    public static int CurrentEnemyCount;

    public TMP_Text Current;
    public TMP_Text Max;
    void Start()
    {
        EnemyCountMax = Enemys.Length;
        CurrentEnemyCount = Enemys.Length;
        Max.text = EnemyCountMax.ToString();  
    }

    // Update is called once per frame
    void Update()
    {          
        Debug.Log(CurrentEnemyCount+"/"+EnemyCountMax);
        Current.text = CurrentEnemyCount.ToString();
    }
}
