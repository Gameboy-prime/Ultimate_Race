using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadNextLevel : MonoBehaviour
{
    public event EventHandler OnEnterLevelEnd;
   
    [SerializeField] private TextMeshProUGUI value;

    
    //References
    public LevelLoader loader;
    public Money money;
    public Stats stat;

    
    
    
    private void Update()
    {
        
        
        
        value.GetComponent<TextMeshProUGUI>().text = "" + money.money.ToString("f0");
    }
    IEnumerator OnTriggerEnter(Collider other)
    {
        OnEnterLevelEnd?.Invoke(this, EventArgs.Empty);
        stat.ShowStatistic();
        yield return new WaitForSeconds(.1f);
       
        
        StartCoroutine( loader.NextLevel());

        
        
        

    }

   
}