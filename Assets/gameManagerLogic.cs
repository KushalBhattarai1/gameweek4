using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;


public class gameManagerLogic : MonoBehaviour
{
    int coinCollect = 0;
    public float timer = 20;
    public TextMeshProUGUI scoringText;
    public TextMeshProUGUI TimerText;

    public GameObject winPannel;
    public GameObject lossPannel;
    public void  coinAdd()
    {
        coinCollect++;
        Debug.Log(coinCollect);
        scoringText.text = "Coin : " + coinCollect; 
    }
    
    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimeSpan timerData = TimeSpan.FromSeconds(timer);
            TimerText.text = "Timer : " + timerData.Seconds;

            if (coinCollect == 6) {
                winPannel.SetActive(true);
               Time.timeScale = 0f;
            }
        }
        else
        {

            lossPannel.SetActive(true);
            Time.timeScale = 0f;
        }


    }

}
