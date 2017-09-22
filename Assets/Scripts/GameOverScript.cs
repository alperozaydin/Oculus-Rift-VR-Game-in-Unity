using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    public static int score;
     Text text;

    public int highScore = 0;
    string highScoreKey = "HighScore";
    


    // Use this for initialization
    void Start () {

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);


        text = GetComponent<Text>();
        text.enabled = true;
        score = ScoreManager.score;
        text.text += score;




    }

    void OnDisable()
    {

        //If our scoree is greter than highscore, set new higscore and save.
        if (score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, score);
            PlayerPrefs.Save();
        }
    }


    // Update is called once per frame
    void Update () {


       

    }
}
