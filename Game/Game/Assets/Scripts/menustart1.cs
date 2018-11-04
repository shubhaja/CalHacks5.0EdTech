using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menustart1 : MonoBehaviour
{

    public void ChangeMenuScreen(string sceneName)
    {
        SceneManager.LoadScene("Level1");
    }
}