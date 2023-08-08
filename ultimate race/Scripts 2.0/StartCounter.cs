using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private GameObject counterObject;

    [SerializeField] private GameObject lapTimer;
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject carAi;
    [SerializeField] private GameObject carAi2;
    
    [SerializeField] private GameObject timer;

    [SerializeField] private AudioSource getReady;
    [SerializeField] private AudioSource go;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCounting());
    }

    IEnumerator StartCounting()
    {
        yield return  new WaitForSeconds(0.5f);
        counter.GetComponent<TextMeshProUGUI>().text = "3";
        counterObject.SetActive(true);
        getReady.Play();
        yield return new WaitForSeconds(1);
        counterObject.SetActive(false);
        
        
        counter.GetComponent<TextMeshProUGUI>().text = "2";
        counterObject.SetActive(true);
        getReady.Play();
        yield return new WaitForSeconds(1);
        counterObject.SetActive(false);

        
        
       
        counter.GetComponent<TextMeshProUGUI>().text = "1";
        counterObject.SetActive(true);
        getReady.Play();
        yield return new WaitForSeconds(1);
        counterObject.SetActive(false);
        
        counter.GetComponent<TextMeshProUGUI>().text = "GO!";
        counterObject.SetActive(true);
        go.Play();

        timer.GetComponent<TimeManager>().enabled = true;
        car.GetComponent<CarController>().enabled = true;
        carAi.GetComponent<CarAi>().enabled = true;
        carAi2.GetComponent<CarAi>().enabled = true;
        lapTimer.GetComponent<LapTimeManagement>().enabled = true;
        yield return new WaitForSeconds(1);
        counterObject.SetActive(false);
        



    }
}
