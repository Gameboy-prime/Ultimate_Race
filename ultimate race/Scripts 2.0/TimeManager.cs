using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float sec=15;
    private string secDisplay;

    private float milli;
    
    [SerializeField] private TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secDisplay=sec.ToString("f0");
        timer.GetComponent<TextMeshProUGUI>().text= "" + secDisplay + ".";
        milli += Time.deltaTime * 10;
        if (milli > 10)
        {
            sec -= 1;
            milli = 0;
        }
        

    }
    public void IncreaseTime()
    {
        sec += 5;

    }
}
