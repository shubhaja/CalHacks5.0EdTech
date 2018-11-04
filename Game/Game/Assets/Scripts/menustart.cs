using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menustart : MonoBehaviour {

    public void changeMenuScreen(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
