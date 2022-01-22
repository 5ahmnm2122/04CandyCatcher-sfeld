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

    [SerializeField] GameObject[] lifeObjects; 

    [SerializeField] PlayerInfo playerInfo;

    [Header("Parameters")]
    [SerializeField] int startTime; //in seconds
    [SerializeField] int score;

    float currentTime;
    int lifeAmmount; 

    private void Start()
    {
        currentTime = startTime;
        nameText.text = playerInfo.playerName;
        scoreText.text = score.ToString();

        lifeAmmount = lifeObjects.Length;
    }

    private void countTime(int startTime)
    {
        currentTime = currentTime - Time.deltaTime;
        //print(currentTime);
        if(currentTime <= 0)
        {
            playerInfo.playerScore = score; 
            if(score > playerInfo.playerHighscore)
            {
                playerInfo.playerHighscore = score; 
            }

            playerInfo.lost = false;
            ManageScenes.Instance.NextScene();
        }
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

    public void LoseLife()
    {
        lifeObjects[lifeAmmount - 1].SetActive(false);
        lifeAmmount -= 1; 
        if(lifeAmmount <= 0)
        {
            playerInfo.playerScore = 0; 
            playerInfo.lost = true;
            ManageScenes.Instance.NextScene();
        }
    }

    private void Update()
    {
        countTime(startTime);
        displayTime(currentTime);
    }
}
