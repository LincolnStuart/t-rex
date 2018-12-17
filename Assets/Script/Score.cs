using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {


    [SerializeField]
    private Text scoreText;
    private float time;
    [SerializeField]
    private int aim = 100;
    [SerializeField]
    private int aimToIncrease = 100;
    private AudioSource audioScore;

    private void Start()
    {
        this.audioScore = GetComponent<AudioSource>();
    }

    public void CalculateScore()
    {
        this.time += Time.deltaTime;
        int score = (System.Convert.ToInt32(this.time * 100) * 7) / 100;
        this.IncreaseLevel(score);
        this.scoreText.text = score.ToString("D5");
    }

    private void IncreaseLevel(int score)
    {
        if (score == this.aim)
        {
            this.aim += this.aimToIncrease ;
            Time.timeScale *= 1.2f;
            this.audioScore.Play();
        }
    }

    public void RestartScore()
    {
        time = 0;
        aim = 100;
    }
}
