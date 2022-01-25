using UnityEngine;


[CreateAssetMenuAttribute(fileName = "PlayerInfo", menuName = "Custom/PlayerInfo")]
public class PlayerInfo : ScriptableObject
{
    public int playerScore;
    public string playerName;
    public int playerHighscore;

    public bool lost; 
}
