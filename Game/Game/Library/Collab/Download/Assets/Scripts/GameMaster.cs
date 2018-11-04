using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        coinsText.text = "Coins: " + coins;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("hello");
        if (collision.transform.CompareTag("Door") && coins >= totalcoins)
        {
            print("goodbye");
            collision.transform.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
