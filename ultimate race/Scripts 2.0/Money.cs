using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public int dollars=0;
    [SerializeField] private TextMeshProUGUI cash;
    
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveMode()
    {
        SaveSystem.SavePlayer(this);
        
    }

    public void LoadMode()
    {
        MoneyData data= SaveSystem.LoadPlayer();
        dollars = data.buck;
        cash.GetComponent<TextMeshProUGUI>().text = "" + dollars;

    }

    public void IncreaseMoney(int rate)
    {
        dollars += rate;
    }
}
