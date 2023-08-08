using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]  private GameObject cam1;

    [SerializeField] private GameObject cam2;
    [SerializeField] private GameObject cam3;

    private int check;
    // Start is called before the first frame update
    void Start()
    {
        check = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("viewmode"))
        {
            check += 1;
            if (check == 3)
            {
                check = 0;
            }

            StartCoroutine(ChangeCam());
        }
        
    }

    IEnumerator ChangeCam()
    {
        yield return new WaitForSeconds(0.1f);
        if (check == 0)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
        }
        else if(check==1)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }
        else
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }
    }
    
    
}
