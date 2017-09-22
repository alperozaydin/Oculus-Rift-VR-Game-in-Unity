using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRunningToPlayer : MonoBehaviour {

	public GameObject target;
	public Animator monsterAnim;

	public Vector3 temp;

	public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning



    public GameObject leftborder;
    public GameObject rightboder;

	void Start () {

		monsterAnim = gameObject.GetComponentInChildren<Animator>();
		monsterAnim.SetInteger("animParam", 1);

//		Vector3 basePosition = new Vector3(Random.Range(3195.731f, 3199.95f), 2233.39f, Random.Range(3196.08f, 3200.72f));

		Vector3 basePosition = new Vector3(Random.Range(rightboder.gameObject.transform.position.x, leftborder.gameObject.transform.position.x), 2233.39f, Random.Range(leftborder.gameObject.transform.position.z, rightboder.gameObject.transform.position.z));

		temp = basePosition;

//		transform.LookAt (target.gameObject.transform.position);
		transform.LookAt(temp);


	}


	void Awake(){

	}


	void Update () {
//		if(Input.GetKeyDown(KeyCode.RightArrow)){
//			monsterAnim.SetInteger("animParam", 1);
//
//		}
//		if(Input.GetKeyDown(KeyCode.LeftArrow)){
//			monsterAnim.SetInteger("animParam", 0);
//			print("left arrow pressed");
//		}

		//Vector3 basePosition = new Vector3(Random.Range(3195.731f, 3199.95f), 2233.39f, Random.Range(3196.08f, 3200.72f));

		//rotate to look at the player
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(temp - transform.position), rotationSpeed * Time.deltaTime);


        //move towards the player
        transform.position += transform.forward * Time.deltaTime * moveSpeed;



//        AttackToPlayer();



	}


	void AttackToPlayer() {


		Vector3 positionCamera = new Vector3(0,0,0);

		Vector3 positonMonster = new Vector3(0,0,0);

        positionCamera = Camera.main.gameObject.transform.position;

		positonMonster = gameObject.transform.position;


		if ((positionCamera.x - positonMonster.x < 1.5) || (positionCamera.z - positonMonster.z < 1.4)){
			
			monsterAnim.SetInteger("animParam", 2);

		}



	}

}
