using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VehicleSelect : MonoBehaviour
{
    public static int CarType;

    [SerializeField] private GameObject car1;
    [SerializeField] private GameObject car2;
    [SerializeField] private GameObject car3;
    [SerializeField] private GameObject car4;
    public LoadingBar loadingBar;
    
    // Start is called before the first frame update
    void Awake()
    {
        CarType = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (CarType < 1)
        {
            CarType = 4;
        }
        if (CarType == 1)
        {
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
        }
        else if (CarType == 2)
        {
            car2.SetActive(true);
            car1.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
        }
        else if (CarType == 3)
        {
            car3.SetActive(true);
            car2.SetActive(false);
            car1.SetActive(false);
            car4.SetActive(false);
        }
        else if (CarType == 4)
        {
            car4.SetActive(true);
            car3.SetActive(false);
            car2.SetActive(false);
            car1.SetActive(false);
        }
        
        else
        {
            CarType = 1;
        }

        
    }

    public void CarRight()
    {
       
        CarType += 1;
        
    }
    
    public void CarLeft()
    {
       
        CarType -= 1;
        
    }

    public void LoadLevelSelection()
    {
        loadingBar.Loading(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    
}
