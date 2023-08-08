using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeManagement : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float milliCount;
    [SerializeField] private static string milliDisplay;

    //[SerializeField] private GameObject minuteBox;
    //[SerializeField] private GameObject secondBox;
    //[SerializeField] private GameObject milliBox;
    [SerializeField] private TextMeshProUGUI minuteBox;
    [SerializeField] private TextMeshProUGUI secondBox;
    [SerializeField] private TextMeshProUGUI milliBox;
    

    // Update is called once per frame
    void Update()
    {
        milliCount += Mathf.Round(Time.deltaTime * 10);
        
        milliDisplay = milliCount.ToString("f0");
        milliBox.GetComponent<TextMeshProUGUI>().text = "" + milliDisplay;

        if (milliCount >=10)
        {
            milliCount = 0;
            secondCount+=1;
        }    

        if (secondCount < 10)
        {
            secondBox.GetComponent<TextMeshProUGUI>().text = "0" + secondCount + ":";
            
        }
        else
        {
            secondBox.GetComponent<TextMeshProUGUI>().text = "" + secondCount+ ":";
        }

        if (secondCount >59)
        {
            secondCount = 0;
            minuteCount += 1;
        }
        if (minuteCount < 10)
        {
            minuteBox.GetComponent<TextMeshProUGUI>().text = "0" + minuteCount + ":";
        }
        else
        {
            minuteBox.GetComponent<TextMeshProUGUI>().text = "" + minuteCount + ":";
        }
    }
}
