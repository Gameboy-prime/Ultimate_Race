using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeComplete : MonoBehaviour
{
    [SerializeField] private GameObject lapCompleteTrig;
    [SerializeField] private GameObject checkPointTrig;

    [SerializeField] private TextMeshProUGUI bestMinute;
    [SerializeField] private TextMeshProUGUI bestSecond;
    [SerializeField] private TextMeshProUGUI bestMilli;

   private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (LapTimeManagement.secondCount < 9)
            {
                bestSecond.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManagement.secondCount + ":";
            }
            else
            {
                bestSecond.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManagement.secondCount + ":";
            }
            if (LapTimeManagement.minuteCount < 9)
            {
                bestMinute.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManagement.minuteCount + ":";
            }
            else
            {
                bestMinute.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManagement.minuteCount+ ":";
            }

            bestMilli.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManagement.milliCount ;

            LapTimeManagement.milliCount = 0;
            LapTimeManagement.secondCount = 0;
            LapTimeManagement.minuteCount = 0;
            
            
            checkPointTrig.SetActive(true);
            lapCompleteTrig.SetActive(false);
            
        }
        
       

    }
}
