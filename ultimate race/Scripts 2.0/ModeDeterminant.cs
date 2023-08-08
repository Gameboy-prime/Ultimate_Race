using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeDeterminant : MonoBehaviour
{
    public GameObject AiCar;

    public GameObject Laptime;

    public GameObject Triggers;

    public GameObject TimerCountDown;
    // Start is called before the first frame update
    void Start()
    {
        if (ModeSelect.mode == 0)
        {
            AiCar.SetActive(true);
            Laptime.SetActive(true);
            Triggers.SetActive(true);
            TimerCountDown.SetActive(false);
        }
        if (ModeSelect.mode == 1)
        {
            AiCar.SetActive(false);
            Laptime.SetActive(false);
            Triggers.SetActive(false);
            TimerCountDown.SetActive(true);
        }
        
    }

    
}
