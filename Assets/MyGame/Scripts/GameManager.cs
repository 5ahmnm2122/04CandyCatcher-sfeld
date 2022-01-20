using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Text timeText;
    [SerializeField] Text scoreText;
    [SerializeField] Text nameText;

    [SerializeField] PlayerInfo playerInfo;

    [Header("Parameters")]
    [SerializeField] int startTime; //in seconds
    [SerializeField] int lives;
    [SerializeField] int score;

    float currentTime;

    private void Start()
    {
        currentTime = startTime;
        nameText.text = playerInfo.playerName;
        scoreText.text = score.ToString();
    }

    private void countTime(int startTime)
    {
        currentTime = currentTime - Time.deltaTime;
        print(currentTime);
    }

    public void AddScore(int _score)
    {
        score += _score;
        scoreText.text = score.ToString();
    }

    void displayTime(float time)
    {
        
        
            int minutes = Mathf.FloorToInt(time/60);
            int seconds = Mathf.RoundToInt(time % 60);
        if (seconds < 10)
            timeText.text = minutes.ToString() + ":0" + seconds.ToString();
        else if (seconds == 60)
            return;
        else
            timeText.text = minutes.ToString() + ":" + seconds.ToString();
        
    }

    private void Update()
    {
        countTime(startTime);
        displayTime(currentTime);
    }
}
