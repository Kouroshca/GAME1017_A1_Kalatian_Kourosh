using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvaSettings : MonoBehaviour
{
    
    public Slider volumeSlider;
    public Button playMusic1Buttun;
    public Button playMusic2Buttun;

    void Start()
    {
        volumeSlider.value = StartMusic.Instance.audioSource.volume;
        volumeSlider.onValueChanged.AddListener(SetVolume);
        playMusic1Buttun.onClick.AddListener(PlayMusic1);
        playMusic2Buttun.onClick.AddListener(PlayMusic2);
        
    }
    public void SetVolume(float volume)
    {
        Debug.Log("Slider "+ volume);
        StartMusic.Instance.SetVolume(volume);

    }
    public void PlayMusic1()
    {
        StartMusic.Instance.Battletheme();
    }
    public void PlayMusic2()
    {
        StartMusic.Instance.Funny();
    }

    public void PlayScene()
    {
        SceneManager.LoadScene("Start");
    }
}
