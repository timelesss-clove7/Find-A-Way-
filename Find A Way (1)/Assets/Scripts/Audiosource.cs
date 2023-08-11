using UnityEngine;

public class Audiosource : MonoBehaviour
{
    static Audiosource instance;
    Vector3 cameraPos;
    MainMenu optionsMenu;

    [Header("Crash")]
    [SerializeField] AudioClip crashClip;
    [Header("SuperPower")]
    [SerializeField] AudioClip superPowerClip;

    float genralVolume;

    void Awake()
    {
        ManageSingleton();
        cameraPos = Camera.main.transform.position;
        optionsMenu = FindObjectOfType<MainMenu>();
        genralVolume = PlayerPrefs.GetFloat("volumeSFX");
    }

    void Update()
    {
        genralVolume = PlayerPrefs.GetFloat("volumeSFX");
    }


    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayCrashSoundEffect()
    {
        AudioSource.PlayClipAtPoint(crashClip, cameraPos, genralVolume);
    }

    public void PlaySuperPowerSoundEffect()
    {
        AudioSource.PlayClipAtPoint(superPowerClip, cameraPos, genralVolume);
    }
}
