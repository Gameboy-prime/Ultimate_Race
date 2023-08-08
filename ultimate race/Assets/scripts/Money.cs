using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Money : MonoBehaviour
{
    public int money;
    public Stats stat;

    void Start()
    {
        //I want to suscribe to the event if the player enters the trigger to end the level so the money can load and save

        LoadNextLevel load= FindObjectOfType<LoadNextLevel>();
        load.OnEnterLevelEnd+=SaveProgress;
        load.OnEnterLevelEnd+= LoadProgress;

    }

    


    public void SaveProgress(object sender, EventArgs message)
    {
        SaveSystem.SaveMoney(this);
        LoadNextLevel load= FindObjectOfType<LoadNextLevel>();
        load.OnEnterLevelEnd -=SaveProgress;
        
        
    }

    public void LoadProgress(object sender, EventArgs args)
    {
        MoneyData data = SaveSystem.LoadMoney();
        money = data.cash;
        LoadNextLevel load= FindObjectOfType<LoadNextLevel>();
        load.OnEnterLevelEnd-= LoadProgress;
    }

    public void MoneyIncrement()
    {
        money += stat.earnings;
        
    }
}
