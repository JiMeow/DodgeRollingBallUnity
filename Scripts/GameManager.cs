using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    [SerializeField] GameObject player;
    [SerializeField] EnermyMovement enermy;
    [SerializeField] CurrentScore currentScore;
    [SerializeField] GameoverManager gameoverManager;
    // Update is called once per frame
    void Update()
    {
        if (enermy.EnermyTransform.position.y < -7)
        {
            currentScore.AddPoint();
            enermy.reset();
        }
        if (player.transform.position.y < -7)
        {
            gameoverManager.GameOver();
        }
    }
}
