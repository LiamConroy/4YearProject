using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject XROrigin;
    public static bool fired;
    public Transform muzzle;
    public GameObject shell;
    public GameObject muzzleFlash;
    public AudioSource m_bang;
   
    [SerializeField] private Animator recoil;
    [SerializeField] private string recoilPlay = "RecoilAnim";
    // public GameObject MainGun;

    public float projectileSpeed = 10f;


    void Start(){
        XROrigin = GameObject.Find("XR Origin");
        // recoil = gameObject.GetComponent<Animation>();
    }

    void Update(){
        
    }
    
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other){
        
    muzzleFlash.SetActive(false);
//  && (BreachControl.fw && !BreachControl.bw)
    if((Maingun.ammoLoaded && RoundDetection.shell.transform.CompareTag("Loaded"))){
        if (other.transform.CompareTag("GameController") && (!fired)){

        Debug.Log("Pew");

        GameObject currentShell = Instantiate(shell, muzzle.position, gameObject.transform.rotation);
        currentShell.transform.Rotate(new Vector3(90,0,0));
        currentShell.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed,ForceMode.Impulse);

        recoil.Play(recoilPlay,0,0.0f);
        recoil.speed = 2.5f;
        muzzleFlash.SetActive(true);
        m_bang.Play();   
        
        RoundDetection.shell.gameObject.tag = "Spent";
        fired = true;
        // RoundDetection.shell = RoundDetection.shell.gameObject.tag = "Spent";
        
        
        }
    }
    }
}
