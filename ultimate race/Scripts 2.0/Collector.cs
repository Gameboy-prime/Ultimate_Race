using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    [SerializeField] private GameObject currentPos;

    [SerializeField] private GameObject pos1;
    [SerializeField] private GameObject pos2;
    [SerializeField] private GameObject pos3;

    [SerializeField] private GameObject pos4;

    public AddTime addTime;

    private int point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        point = addTime.count;
        
        if (point == 1)
        {
            currentPos.transform.position = pos1.transform.position;
        }
        if (point == 2)
        {
            currentPos.transform.position = pos2.transform.position;
        }
        if (point == 3)
        {
            currentPos.transform.position = pos3.transform.position;
        }
        if (point == 4)
        {
            currentPos.transform.position = pos4.transform.position;
        }
        
    }
}
