using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenuAttribute(fileName = "PlayerInfo", menuName = "Custom/PlayerInfo")]
public class PlayerInfo : ScriptableObject
{
    public int playerScore;
    public string playerName;
    public int playerHighscore; 
}
