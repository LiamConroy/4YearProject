using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    public GameObject panel;
    // Start is called before the first frame update

    public void setActive(){
        panel.SetActive(true);
    }

    public void setInactive(){
        panel.SetActive(false);
    }


}
