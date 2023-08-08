using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    [SerializeField] private Transform spawnLocation;
    

    [SerializeField] private GameObject spawnEffect;


    private float miliCount;

    private float SecondCount;

    private float check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        miliCount += Time.deltaTime*10;
        if (miliCount > 9)
        {
            miliCount = 0;
            SecondCount += 1;
        }

        if (SecondCount >= 10)
        {
            SecondCount = 0;
            check++;
            if (check < 5)
            {
                Invoke("Spawn",0.001f);
            }
            
        }
        
    }

    private void Spawn()
    {
        GameObject effect = Instantiate(spawnEffect, spawnLocation.position, Quaternion.identity);
        Destroy(effect,1f);
        Instantiate(enemy, spawnLocation.position , Quaternion.identity);
        
    }
}
