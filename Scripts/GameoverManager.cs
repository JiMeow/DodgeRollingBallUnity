using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject screen;
    [SerializeField] Text currentScore;
    [SerializeField] Text finalScore;
    public void GameOver()
    {
        screen.SetActive(true);
        finalScore.text = currentScore.text;
        currentScore.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
