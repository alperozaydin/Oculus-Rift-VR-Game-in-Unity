using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour {

	public GameObject monsterPrefab;

	public float spawnTime = 4.5f;
	// Use this for initialization
	void Start () {
		

		Spawn();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);


	}
	
	// Update is called once per frame
	void Update () {

		
	}


	void Spawn(){
		
		Vector3 position = new Vector3(Random.Range(3157.38f, 3195.08f), 2233.39f, Random.Range(3170.62f, 3196.59f));
		var newMonster = Instantiate(monsterPrefab, position, Quaternion.identity);

	}
}
