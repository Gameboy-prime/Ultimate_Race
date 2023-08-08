using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI enemyCount;
    public int enemyCountValue;
    public string enemyCountDisplay;
    private int scoreValue;
    public string scoreDisplay;

    
   

    public void SetScore()
    {
        //Check in every update to see if the health of the enemy is zero, then increase the enemy Body count and the score
        //the variable was made public static in the shooting AI class so as to nacess it in the score class
    
        enemyCountValue += 1;
        enemyCountDisplay = enemyCountValue.ToString("f0");
        enemyCount.GetComponent<TextMeshProUGUI>().text = ":" + enemyCountDisplay + ".";
        scoreValue += 10;
        scoreDisplay = scoreValue.ToString("F0");
        score.GetComponent<TextMeshProUGUI>().text = ":" + scoreDisplay + ".";

        
    }
}
