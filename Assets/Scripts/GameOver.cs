using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public static int score;
    Text text;


    // Use this for initialization
    void Start () {

        score = ScoreManager.score;


    }
	
	// Update is called once per frame
	void Update () {

        text.text = text.text + score;

    }
}
