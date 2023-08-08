using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int mode;

    public void RaceMode()
    {
        mode = 0;
    }
    public void ScoreMode()
    {
        mode = 2;

    }
    public void TimerMode()
    {
        mode = 1;

    }
}
