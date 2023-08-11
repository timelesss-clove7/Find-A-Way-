using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMain : MonoBehaviour
{
    PrimarySystem primarySystem;
    Barectates barectates;
    public string secretToggleString;
    [SerializeField] GameObject panel;

    void Start()
    {
        barectates = FindObjectOfType<Barectates>();
    }

    public void PauseButton()
    {
        //barectates.moveSpeed = 0;
        panel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
