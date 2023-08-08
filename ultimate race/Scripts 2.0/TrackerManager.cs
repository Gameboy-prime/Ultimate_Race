using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerManager : MonoBehaviour
{
   #region singleton

   public static TrackerManager instance;

   private void Awake()
   {
      instance= this;
   }

   #endregion

   public GameObject tracker;
}
