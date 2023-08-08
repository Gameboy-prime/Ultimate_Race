using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public LoadingBar loadingBar;
    public Animator transition;
    

    public IEnumerator NextLevel()
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(2);

        loadingBar.Loading(1);
    }

    
}