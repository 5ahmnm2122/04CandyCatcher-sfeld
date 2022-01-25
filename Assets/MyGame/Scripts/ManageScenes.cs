using UnityEngine;
using UnityEngine.SceneManagement; 

public class ManageScenes : MonoBehaviour
{
    private static ManageScenes _instance;

    public static ManageScenes Instance { get { return _instance; } }

    Scene currentScene; 

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void NextScene()
    {
        currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }

    public void LoadSpecificScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}

