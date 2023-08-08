using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MoneyData 
{
     public int buck;
    public MoneyData(Money money)
    {
        buck = money.dollars;

    }
}
