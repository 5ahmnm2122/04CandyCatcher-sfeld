using UnityEngine;
using UnityEngine.UI; 

public class EndScreen : MonoBehaviour
{
    [SerializeField] Button retryButton;
    [SerializeField] Button quitButton;

    [SerializeField] Text winText;
    [SerializeField] Text scoreText;
    [SerializeField] Text highscoreText;
    [SerializeField]PlayerInfo playerInfo; 

    private void Start()
    {
        quitButton.onClick.AddListener(() => 
        {
            print("QuitGame!");
            Application.Quit();
        });

        retryButton.onClick.AddListener(() =>
        {
            ManageScenes.Instance.LoadSpecificScene(0);
        });

        SetScoreTexts();
    }

    void SetScoreTexts()
    {
        if (playerInfo.playerScore >= playerInfo.playerHighscore && !playerInfo.lost)
        {
            winText.text = "New Highscore!";
        }

        else if (!playerInfo.lost)
            winText.text = "You Won!";
        else
            winText.text = "You lost";

        scoreText.text = "Your Score: " + playerInfo.playerScore;
        highscoreText.text = "All Time Best: " + playerInfo.playerHighscore;
    }

}




