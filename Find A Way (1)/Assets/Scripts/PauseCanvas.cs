using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseCanvas : MonoBehaviour
{
    PrimarySystem primarySystem;
    [SerializeField] GameObject Panel;
    Barectates barectates;
    Player player;
    [SerializeField] TextMeshProUGUI pauseScoreText;
    [SerializeField] TextMeshProUGUI pauseHighScoreText;

    void Awake()
    {
        player = FindObjectOfType<Player>();
        primarySystem = FindObjectOfType<PrimarySystem>();
        barectates = FindObjectOfType<Barectates>();
    }

    void Update()
    {
        if (primarySystem.currentScore.ToString() == null)
        {
            Debug.Log("Karra li basti");
        }
        pauseScoreText.text = "Score : " + primarySystem.currentScore.ToString("0000");
        pauseHighScoreText.text = "High-Score : " + PlayerPrefs.GetInt("HighScore", 0).ToString("0000");
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
    public void ResetButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MAIN!!!");
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
