using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DropdownMenuJump : MonoBehaviour {

    public PlayerMovement moving;
    public CharacterController2D characterprop;
    public Dropdown myDropdown2;
    // Update is called once per frame
    void Update()
    {
        switch (myDropdown2.value)
        {
            case 1:
                characterprop.m_JumpForce = 300f;
                Debug.Log(characterprop.m_JumpForce);
                break;
            case 2:
                characterprop.m_JumpForce = 1000f;
                Debug.Log(characterprop.m_JumpForce);
                break;
        }
    }
}

