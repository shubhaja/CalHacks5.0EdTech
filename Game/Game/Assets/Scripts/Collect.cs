using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {
    public Animator animator;
    private GameMaster gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            GetComponent<Collider2D>().enabled = false;
            StartCoroutine(Gain());
            gm.coins += 1;
        }
    }

    IEnumerator Gain()
    {
        animator.SetBool("collect", true);
        yield return new WaitForSeconds(0.65f);
        Destroy(gameObject);
    }
}
