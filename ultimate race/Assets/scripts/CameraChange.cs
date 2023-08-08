using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private GameObject cam1;

    [SerializeField] private GameObject cam2;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }
        

    // Update is called once per frame
    void Update()
    {
        if (count == 2)
        {
            count = 0;
            
        }
        if (Input.GetButtonDown("viewmode"))
        {
            StartCoroutine(ChangeCamAngle());
            count += 1;
        }
    }

    IEnumerator ChangeCamAngle()
    {
        yield return  new WaitForSeconds(0.2f);
        if (count == 1)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }

        if (count == 0)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
    
    
}
