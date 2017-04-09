using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool isPaused = false;
    bool isAudioMute = false;

    public Button audioButton;
    public AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(audioSource);
    }

	void Start () {
        
        audioSource.Play();
	}
    
    public void PauseGame()
    {
        Debug.Log("Paused");
        isPaused = !(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;
            audioSource.Stop();
        }
        else
        {
            Time.timeScale = 1;
            audioSource.Play();
        }
    }

    public void SoundToggle()
    {
        isAudioMute = !(isAudioMute);

        if(isAudioMute)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }
	
	void Update () {
    }
}
