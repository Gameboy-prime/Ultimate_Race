using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    //[SerializeField] private GameObject mainMenu;
    //[SerializeField] private GameObject option;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /*public void LoadOption()
    {
        mainMenu.SetActive(false);
        option.SetActive(true);
    }

    public void BackToMainMenu()
    {
        option.SetActive(false);
        mainMenu.SetActive(true);
        SceneManager.LoadScene("main menu");
    }*/

    public void QuitGame()
    {
        Debug.Log("Game has ended");
        Application.Quit();
    }
    public void BackToMainMenu()
    {
        
        SceneManager.LoadScene("main menu");
    }
    
}
