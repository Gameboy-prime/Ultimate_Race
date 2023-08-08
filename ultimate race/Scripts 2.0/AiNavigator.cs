using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiNavigator : MonoBehaviour
{
    [SerializeField] private GameObject track1;
    [SerializeField] private GameObject track2;
    [SerializeField] private GameObject track3;
    [SerializeField] private GameObject track4;
    [SerializeField] private GameObject track5;
    [SerializeField] private GameObject track6;
    [SerializeField] private GameObject track7;
    [SerializeField] private GameObject track8;
    [SerializeField] private GameObject track9;
    [SerializeField] private GameObject track10;
    [SerializeField] private GameObject track11;
    [SerializeField] private GameObject track12;
    [SerializeField] private GameObject track13;
    [SerializeField] private GameObject track14;
    [SerializeField] private GameObject track15; 
    private int tracker=1;
   // private int count=0;
   
    [SerializeField] private GameObject originalTracker;
    private bool checker;
    
    public CarAi brake;
    private Transform limit;

    private void Update()
    {
        //CheckLimit();
        
         if (tracker == 1)
        {
            originalTracker.transform.position = track1.transform.position;
            
        }
        if (tracker == 2)
        {
            originalTracker.transform.position = track2.transform.position;
            
        } 
        if (tracker == 3)
        {
            originalTracker.transform.position = track3.transform.position;
           
        }
        if (tracker == 4)
        {
            originalTracker.transform.position = track4.transform.position;
            
        }
        if (tracker == 5)
        {
            originalTracker.transform.position = track5.transform.position;
            
        }
        if (tracker == 6)
        {
            originalTracker.transform.position = track6.transform.position;
            
        }
        if (tracker == 7)
        {
            originalTracker.transform.position = track7.transform.position;
           
        }
        if (tracker == 8)
        {
            originalTracker.transform.position = track8.transform.position;
            
        }
        if (tracker == 9)
        {
            originalTracker.transform.position = track9.transform.position;
            
        } if (tracker == 10)
        {
            originalTracker.transform.position = track10.transform.position;
            
        } if (tracker == 11)
        {
            originalTracker.transform.position = track11.transform.position;
            
        }
        if (tracker == 12)
        {
            originalTracker.transform.position = track12.transform.position;
            
        }
        if (tracker == 13)
        {
            originalTracker.transform.position = track13.transform.position;
            
        }
        if (tracker == 14)
        {
            originalTracker.transform.position = track14.transform.position;
           
        }
        if (tracker == 15)
        {
            originalTracker.transform.position = track15.transform.position;
            
        }

        //trackerSetter();
    }

    private void CheckLimit()
    {
        limit = CarManager.instance.car.transform;
        float distance = Vector3.Distance(limit.position, transform.position);
        if (distance >= 1 && distance <= 1.5 )
        {
            brake.ApplyBraking();
        }
    }

   

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("prime1.0"))
        {
            checker = true;
            
            this.GetComponent<BoxCollider>().enabled = false;
            tracker+=1;
            if (tracker== 16)
            {
                //count = 0;
                tracker = 0;
            }
            
            yield return  new WaitForSeconds(0.1f);
            this.GetComponent<BoxCollider>().enabled = true;




            /*if (checker)
            {
                brake.ApplyBraking();
                yield return  new WaitForSeconds(1.5f);
                checker = false;
            }*/

            
           
            
            
            
        }
       

    }
}
