using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManagerLogic : MonoBehaviour
{
    int coinCollect = 0;

    public TextMeshProUGUI scoringText;

    public void  coinAdd()
    {
        coinCollect++;
        Debug.Log(coinCollect);
        scoringText.text = "Coin : " + coinCollect; 
    }
}
