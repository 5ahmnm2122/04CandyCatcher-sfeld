using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField]int score = 1;
    [SerializeField]bool badCandy;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
            if (badCandy)
            {
                gameManager.LoseLife();
            }
            gameManager.AddScore(score);
            Destroy(gameObject);
        }
    }
}
