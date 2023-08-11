using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] AudioMixer audioMixer;
    void Start()
    {
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore", 0).ToString("0000");
        audioMixer.SetFloat("VolumeMain", PlayerPrefs.GetFloat("volumeMain", 0));
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("qualityindex", 0));
        Time.timeScale = 1;
    }
    public void StartButton()
    {
        SceneManager.LoadScene("MAIN!!!");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void OptionButton(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
