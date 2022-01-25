using UnityEngine;
using UnityEngine.UI; 

public class MenuManager : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] InputField nameInput;

    [SerializeField] PlayerInfo playerInfo;

    string currentName;

    public void getName()
    {
        currentName = nameInput.textComponent.text;
        if (currentName != null)
            startButton.interactable = true;
    }


    private void Start()
    {
        startButton.onClick.AddListener(() =>
            {
                playerInfo.playerName = currentName;
                ManageScenes.Instance.NextScene();
            });
    }

    
}
