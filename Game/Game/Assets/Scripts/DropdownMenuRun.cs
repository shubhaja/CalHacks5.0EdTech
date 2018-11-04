using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropdownMenuRun : MonoBehaviour
{
    public PlayerMovement moving;
    public CharacterController2D characterprop;
    public Dropdown myDropdown;
    // Update is called once per frame
    void Update()
    {
        switch (myDropdown.value)
        {
            case 1:
                moving.runSpeed = 20f;
                Debug.Log(moving.runSpeed);
                break;
            case 2:
                moving.runSpeed = 60f;
                Debug.Log(moving.runSpeed);
                break;
            case 3:
                moving.runSpeed = 100f;
                Debug.Log(moving.runSpeed);
                break;
        }
    }
}