using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrintHighestScore : MonoBehaviour {

    public int highScore;
    string highScoreKey = "HighScore";
    public GameObject HighScoreGameobject;



    TextMesh textMeshA;


    void Awake()
    {

        HighScoreGameobject = GameObject.Find("Canvas/Menu/HighestScoreButton");

    }

    // Use this for initialization
    void Start () {
        
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
      

    }
	
	// Update is called once per frame
	void Update () {


        textMeshA = HighScoreGameobject.GetComponent<TextMesh>();
        textMeshA.text = textMeshA.text + highScore;

    }
}
