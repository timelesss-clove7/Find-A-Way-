using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PrimarySystem : MonoBehaviour
{
    [SerializeField] GameObject loseMenu;
    [SerializeField] int scoreVariation = 25;
    [SerializeField] int breakableBlocks;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreTextMenu;
    [SerializeField] TextMeshProUGUI highScoreTextMenu;
    [SerializeField] Animator myAnimator;
    int highscore;
    public int currentScore;

    void Awake()
    {
        currentScore = 0;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("HighScore");
        scoreText.text = currentScore.ToString("0000");
    }

    public void IncreaseScore()
    {
        currentScore += scoreVariation;
        scoreText.text = currentScore.ToString("0000");
        if (currentScore > highscore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highscore = PlayerPrefs.GetInt("HighScore");
        }
    }

    public void LoseMenuSetup()
    {
        loseMenu.SetActive(true);
        myAnimator.SetBool("Lose", true);
        scoreTextMenu.text = currentScore.ToString("0000");
        highScoreTextMenu.text = "High Score : " + PlayerPrefs.GetInt("HighScore", 0).ToString("0000");
    }

    public void LoseMenuDismantle()
    {
        loseMenu.SetActive(false);
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}