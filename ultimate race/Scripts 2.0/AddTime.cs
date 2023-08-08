using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public int count=1;
    public TimeManager time;
    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        time.IncreaseTime();
    }

    
}
