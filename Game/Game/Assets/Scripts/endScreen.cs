using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endScreen : MonoBehaviour {

    public void changeMenuScreen(string sceneName)
    {
        SceneManager.LoadScene("endScreen");
    }
}
