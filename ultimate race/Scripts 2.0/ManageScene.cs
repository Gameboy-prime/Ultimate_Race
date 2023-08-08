using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public Animator transition;

    [SerializeField] private float transitionTime;

    public void LoadLevel1()
    {
        StartCoroutine(TransitionLeve());
    }

    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Quit Application");
    }

    IEnumerator TransitionLeve()
    {
        transition.SetTrigger("start");
        
        yield return  new WaitForSeconds(transitionTime);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
}
