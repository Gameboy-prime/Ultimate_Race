using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class MoneyData 
{
    public int cash;

    public MoneyData(Money money)
    {
        cash = money.money;
    }
}
