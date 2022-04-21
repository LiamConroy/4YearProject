using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleRay : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    private void Awake(){
        toggleReference.action.started += Toggle;
    }
    // Start is called before the first frame update
    
    private void OnDestroy(){
        toggleReference.action.started -= Toggle;       
    }

    private void Toggle(InputAction.CallbackContext context){
        bool IsActive = !gameObject.activeSelf;
        gameObject.SetActive(IsActive);
        Debug.Log("pressed");
    }
    // Update is called once per frame
}
