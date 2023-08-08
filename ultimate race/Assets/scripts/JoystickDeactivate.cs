using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickDeactivate : MonoBehaviour
{
    #region singleton

    public static JoystickDeactivate instance;

    private void Awake()
    {
       instance=this;
    }

    #endregion

    public GameObject joyCanvas;
}
