using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class LoseCanvas : MonoBehaviour
{
    [SerializeField] Button watchAD;
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void WatchAD()
    {
        AdManager.Instance.ShowAd(this);

        watchAD.interactable = false;
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}