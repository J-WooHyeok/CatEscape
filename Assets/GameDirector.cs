using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject GameOver;
    GameObject Score;
    GameObject arrowPrefab;
    public int score = 0;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.GameOver = GameObject.Find("GameOver");
        this.Score = GameObject.Find("Score");
        this.arrowPrefab = GameObject.Find("arrowPrefab");
    }


    // Update is called once per frame
    void Update()
    {
        if(this.hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            this.GameOver.GetComponent<Text>().text = "게임 오버!";
            Time.timeScale = 0f;
            gameOver = true;
        }
    }

    public void DecreaseHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseScore()
    {
        score++;
        this.Score.GetComponent<Text>().text = "Score : " + score;
    }
}
