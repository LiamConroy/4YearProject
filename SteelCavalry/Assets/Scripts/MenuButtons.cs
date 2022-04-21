using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    Scene SceneName;
    void Start()
    {
       SceneName = SceneManager.GetActiveScene();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTutorial(){
        SceneManager.LoadScene("TutorialSceneNew");
    }

    public void LoadLevelOne(){
        SceneManager.LoadScene("LevelOne");
    }

    public void LoadMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Close(){
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void Restart(){
        SceneManager.LoadScene(SceneName.name);
    }

}
