using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private GameObject raceFinishTrig;

    public int count;

    

    private string countDisplay;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            raceFinishTrig.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            count += 1;
            countDisplay = count.ToString("F0");
            countText.GetComponent<TextMeshProUGUI>().text = countDisplay;
            
        }
    }

    
}
