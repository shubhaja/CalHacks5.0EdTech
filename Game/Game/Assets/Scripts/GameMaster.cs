using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameMaster : MonoBehaviour
{
    public int coins = 0;
    public int totalcoins;
    public Text coinsText;

    void Start()
    {
        coinsText.text = "Coins: 0";
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins Remaining: " + (totalcoins - Math.Min(coins, totalcoins));
    }
}
