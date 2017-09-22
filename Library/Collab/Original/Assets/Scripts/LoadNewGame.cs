using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewGame : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
