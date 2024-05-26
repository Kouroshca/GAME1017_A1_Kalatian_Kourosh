using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMusic : MonoBehaviour
{
    public static StartMusic Instance { get; private set; }
    public AudioSource audioSource;
    public AudioClip music1;
    public AudioClip music2;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
    }
    public void Battletheme()
    {
        audioSource.clip = music1;
        audioSource.Play();

    }
    public void Funny()
    {
        audioSource.clip = music2;
        audioSource.Play();
    }
    public void StopMusic()
    {
        audioSource.Stop();
    }
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
