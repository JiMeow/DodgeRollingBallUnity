using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    Text scoreText;
    int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    public void AddPoint()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }
}
