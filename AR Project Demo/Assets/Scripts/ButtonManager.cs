// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // private AudioManager audioManager;
    private void Start()
    {
        // audioManager = (AudioManager)FindObjectOfType(typeof(AudioManager));
        // audioManager = GameObject.Find("MNGR_AudioManager").GetComponent<AudioManager>();
        // print("max fps");
        Application.targetFrameRate = 30;
    }

    public  void SceneToLoad( int index )
    {
        // audioManager.Play("click");
        // var _sceneAsset = button.GetComponent<ScenePicker>().SceneToLoad;
        SceneManager.LoadScene(index);
    }

    public void ClickSound()
    {
        AudioManager.instance.Play("click");
    }

    public void PauseTime()
    {
        // audioManager.Play("click");
    Time.timeScale = 0;
    }
    public void ResumeTime()
    {
        // audioManager.Play("click");
        Time.timeScale = 1;
    }

    public void ReloadScene()
    {
        // audioManager.Play("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void ExitGame()
    {
        // audioManager.Play("click");
        Application.Quit();
    }
    
     
}
