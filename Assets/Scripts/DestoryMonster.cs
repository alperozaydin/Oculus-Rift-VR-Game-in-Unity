using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestoryMonster : MonoBehaviour {

    public static int newscore = 50;
    public static int hitpoint = 150;
   

    // Use this for initialization
    void Start () {

     



    }
	
	// Update is called once per frame
	void Update () {

      
    }


	void OnCollisionEnter (Collision col)
	{

		
		if(col.gameObject.tag == "monster1")
		{
          
            ScoreManager.score += newscore;
			Destroy(col.gameObject);
		}

	}


}
