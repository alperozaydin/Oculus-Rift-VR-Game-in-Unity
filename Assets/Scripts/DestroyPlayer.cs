using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "monster1")
        {
            Healthbar scriptAInstance = GetComponent<Healthbar>();
            scriptAInstance.TakeDamage(20);
            Destroy(col.gameObject);
        }

    }

}
