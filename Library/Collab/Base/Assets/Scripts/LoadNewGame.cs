using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewGame : MonoBehaviour {

    public Animator StartGameBUtton;
  

    void Awake()
    {
        Time.timeScale = 0;
    }



     
    
  


    void OnMouseDown()
    {

        SceneManager.LoadScene("Main");
        Time.timeScale = 1;



    }


  
}
