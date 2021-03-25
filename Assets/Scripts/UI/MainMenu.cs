using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private Music music;
    [SerializeField] Text highScore;
    [SerializeField] Button musicToggleButton;
    [SerializeField] float volume=0.1f;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        music = FindObjectOfType<Music>();
        AudioListener.volume = volume;
    }

  public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

  public void PauseMusic()
    {
        music.ToggleSound();
        UpdasteMusic();
    }

    private void UpdasteMusic()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = volume;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
