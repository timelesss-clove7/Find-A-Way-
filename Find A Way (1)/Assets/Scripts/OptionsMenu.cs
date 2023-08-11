using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField] Slider slider;
    public AudioMixer SFXMixer;
    [SerializeField] Slider SFXSlider;
    MainMenu mainMenu;
    void Start()
    {
        mainMenu = FindObjectOfType<MainMenu>();
        slider.value = PlayerPrefs.GetFloat("volumeMain", 0);
        SFXSlider.value = PlayerPrefs.GetFloat("volumeSFX", 1);
    }
    public void SetVolumeMain(float volume)
    {
        PlayerPrefs.SetFloat("volumeMain", volume);
        audioMixer.SetFloat("VolumeMain", PlayerPrefs.GetFloat("volumeMain", 0));
        Debug.Log(volume);
    }

    public void SetVolumeSFX(float volume)
    {
        PlayerPrefs.SetFloat("volumeSFX", volume);
        Debug.Log(volume + " SFX");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
