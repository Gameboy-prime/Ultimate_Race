using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [SerializeField] private GameObject statBox;
    [SerializeField] private TextMeshProUGUI missionCompleteBox;
    [SerializeField] private TextMeshProUGUI timeCompleteBox;
    [SerializeField] private TextMeshProUGUI enemyKilledBox;
    [SerializeField] private TextMeshProUGUI totalEarningsBox;
    [SerializeField] private TextMeshProUGUI continueBox;
    

    [SerializeField] private int missionMoney;

    private int enemyMoney;
    public int earnings;
    
    private string enemyMoneyDisplay;
    private string earningsDisplay;

        
    
    //References
    public ScoreManager scoreManager;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    
    public void ShowStatistic()
    {
        
        StartCoroutine(ShowStat());

    }

    

    IEnumerator ShowStat()
    {
        
        statBox.SetActive(true);
        Deactivation();
        //Mission complete stats
        yield return new WaitForSeconds(1);
        missionCompleteBox.GetComponent<TextMeshProUGUI>().text= "Mission Complete ---- " + missionMoney + ".";
        yield return new WaitForSeconds(.5f);
        missionCompleteBox.GetComponent<TextMeshProUGUI>().enabled = true;
        
        
        //enemy killed stats
        enemyMoney = scoreManager.enemyCountValue * 100;
        enemyMoneyDisplay = enemyMoney.ToString("f0");
        enemyKilledBox.GetComponent<TextMeshProUGUI>().text = "Enemies Killed = " + scoreManager.enemyCountDisplay + " ---- " + enemyMoneyDisplay + ".";
        yield return new WaitForSeconds(.5f);
        enemyKilledBox.GetComponent<TextMeshProUGUI>().enabled = true;
        
        
        //Total Earnings stats
        earnings = enemyMoney + missionMoney;
        earningsDisplay = earnings.ToString("f0");
        totalEarningsBox.GetComponent<TextMeshProUGUI>().text = "Total Earnings ---- " + earningsDisplay + ".";
        yield return new WaitForSeconds(.5f);
        totalEarningsBox.GetComponent<TextMeshProUGUI>().enabled = true;
        
        yield return new WaitForSeconds(.5f);
        
        //continueBox.GetComponent<TextMeshProUGUI>().enabled = true;
        


    }

    private void Deactivation()
    {



        FindObjectOfType<GunController>().enabled = false;
        FindObjectOfType<CarController>().enabled = false;
        FindObjectOfType<EnemyAi>().enabled = false;
        FindObjectOfType<EnemySpawn>().enabled = false;
    }
}
