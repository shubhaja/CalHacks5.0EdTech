using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;
    [SerializeField]Transform spawnPoint;


    public float runSpeed = 40f;
    float horizontal = 0f;
    bool jump = false;
    bool crouch = false;
    bool life = true;
    int deaths = 0;
    public Text deathsText;

    // Update is called once per frame
    void Update () {
        if (life)
        {
            horizontal = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontal));
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJump", true);
            }
            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }
        deathsText.text = "Deaths: " + deaths;
	}

    public void OnLanding ()
    {
        animator.SetBool("IsJump", false);
    }

    public void OnCrouching ()
    {
        animator.SetBool("IsCrouch", crouch);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Death"))
        {
            horizontal = 0;
            StartCoroutine(Respawn());   
        }
    }

    IEnumerator Respawn()
    {
        life = false;
        deaths += 1;
        animator.SetBool("Life", false);
        yield return new WaitForSeconds(0.65f);
        controller.transform.position = spawnPoint.position;
        animator.SetBool("Life", true);
        life = true;
    }

    void FixedUpdate ()
    {
        controller.Move(horizontal * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }


}
