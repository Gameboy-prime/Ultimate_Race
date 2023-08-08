using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public LoadingBar loading;
    //These Are methods that Load Different Levels
    

    public void LoadLevel1()
    {
        loading.Loading(2);
        //SceneManager.LoadScene("level 1");
    }
    public void LoadLevel2()
    {
        loading.Loading(3);
        
        //SceneManager.LoadScene("level 2");
    }
    public void LoadLevel3()
    {
        loading.Loading(4);
        //SceneManager.LoadScene("level 3");
    }
    public void LoadLevel4()
    {
        loading.Loading(5);
        //SceneManager.LoadScene("level 4");
    }
}
