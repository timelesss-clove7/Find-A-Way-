using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMain : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void PauseButton()
    {
        panel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
