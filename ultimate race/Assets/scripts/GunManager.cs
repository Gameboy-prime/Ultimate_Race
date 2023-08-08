using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [SerializeField] private GameObject machineGun;

    [SerializeField] private GameObject bazooka;

    private bool check;
    
    // Start is called before the first frame update
    void Start()
    {
        check = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Check to see if the key TAB eas pressed so as to switch between weapons
        if (Input.GetKeyDown(KeyCode.Tab) && check)
        {
            machineGun.SetActive(false);
            bazooka.SetActive(true);
            check=false;


        }
        else if (Input.GetKeyDown(KeyCode.Tab) && !check)
        {
            machineGun.SetActive(true);
            bazooka.SetActive(false);
            check=true;
        }
    }
}
