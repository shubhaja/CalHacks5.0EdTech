using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameMaster gm;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player") && gm.coins >= gm.totalcoins)
        {
            transform.GetComponent<Renderer>().enabled = true;
            SceneManager.LoadScene("endScene");
        }
    }
}
