using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunBar : MonoBehaviour
{
    public Slider slider;
   

    public void SetMaxBullet(int amount)
    {
        slider.maxValue= amount;
        slider.value= amount;
        //grad.Evaluate(1f);

    }

    public void SetBullet(int amount)
    {
        slider.value= amount;
        //fill.color= grad.Evaluate(slider.normalizedValue);
        
    }
    

    
    

}
