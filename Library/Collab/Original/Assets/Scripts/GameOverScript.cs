﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    public static int score;
     Text text;



    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();
        text.enabled = true;
        score = ScoreManager.score;
        text.text += score;


    }
	
	// Update is called once per frame
	void Update () {

       

    }
}