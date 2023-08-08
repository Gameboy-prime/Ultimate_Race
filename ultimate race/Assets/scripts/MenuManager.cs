using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject pauseCanvas;
    public GameObject quitBox;
    public LoadingBar loadingBar;


    //private GameObject joyCanvas;
   
    

    public void PauseGame()
    {
        
        StartCoroutine(Pause());

    }

    public void ResumeGame()
    {
        
        StartCoroutine(Resume());

    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        
        FindObjectOfType<InstantiateVehicle>().SpawnVehicle();
        
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        
        loadingBar.Loading(0);

    }
    public void QuitMenu()
    {
        pauseCanvas.SetActive(false);
        quitBox.SetActive(true);
        
        
    
    }
    
    public void DisableQuitMenu()
    {
        quitBox.SetActive(false);
        pauseCanvas.SetActive(true);
        
    }

    IEnumerator Pause()
    {
        pauseCanvas.SetActive(true);
        
        //joyCanvas.SetActive(false);
        
        
        mainCanvas.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        //FindObjectOfType<Animator>().runtimeAnimatorController.name = "Pause Canvas";
        Time.timeScale = 0f;
    }


    IEnumerator Resume()
    {
        Time.timeScale = 1f;
        
        mainCanvas.SetActive(true);
        
        //joyCanvas.SetActive(true);
        
        pauseCanvas.SetActive(false);
        yield return new WaitForSeconds(.2f);
    }

    private void Update()
    {
        //joyCanvas = JoystickDeactivate.instance.joyCanvas;
        Debug.Log(Time.timeScale);
    }
}
