using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreHandler : MonoBehaviour
{
    [SerializeField] Text Highscore;
    [SerializeField] Text Score;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetMouseButton(0))
        {
            score++;
            Score.text = score.ToString();
            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }
          
    }
}
