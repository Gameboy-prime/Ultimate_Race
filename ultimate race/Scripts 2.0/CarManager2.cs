using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager2 : MonoBehaviour
{
    #region Singleton1

    public static CarManager2 instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject car2;
}