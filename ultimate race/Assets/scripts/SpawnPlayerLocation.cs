using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerLocation : MonoBehaviour
{
    [SerializeField] private GameObject location1;
    [SerializeField] private GameObject location2;
    [SerializeField] private GameObject location3;
    [SerializeField] private GameObject originalLocation;
    private int point;
    private Transform CarPoint;
    public SpawnPlayer spawnplayer;

    // Start is called before the first frame u pdate
    void Start()
    {
        CarPoint = EnemyManager.instance.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance1 = Vector3.Distance(CarPoint.position, location1.transform.position);
        float distance2 = Vector3.Distance(CarPoint.position, location2.transform.position);
        float distance3 = Vector3.Distance(CarPoint.position, location3.transform.position);
        if (distance1 < distance2 && Input.GetKey(KeyCode.Mouse2))
        {
            originalLocation.transform.position = location1.transform.position;
            spawnplayer.Spawn();
            
        }
        else if (distance2 < distance3 && Input.GetKey(KeyCode.Mouse2))
        {
            originalLocation.transform.position = location2.transform.position;
            spawnplayer.Spawn();
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse2))
            {
                originalLocation.transform.position = location3.transform.position;
                spawnplayer.Spawn();
            }
            
        }

    }

    
}
