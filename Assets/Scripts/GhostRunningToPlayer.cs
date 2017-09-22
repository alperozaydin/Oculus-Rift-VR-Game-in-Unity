using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostRunningToPlayer : MonoBehaviour {


	public GameObject target;
//	public Animator monsterAnim;

	public Vector3 temp;

	public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning



    public GameObject leftborder;
    public GameObject rightboder;


	// Use this for initialization
	void Start () {

        //		monsterAnim = gameObject.GetComponentInChildren<Animator>();
        //		monsterAnim.SetInteger("animParam", 1);

        Vector3 basePosition = new Vector3(Random.Range(rightboder.gameObject.transform.position.x, leftborder.gameObject.transform.position.x), 2233.39f, Random.Range(leftborder.gameObject.transform.position.z, rightboder.gameObject.transform.position.z));

        temp = basePosition;

        transform.LookAt(temp);
    }
	
	// Update is called once per frame
	void Update () {


        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(temp - transform.position), rotationSpeed * Time.deltaTime);

		transform.position += transform.forward * Time.deltaTime * moveSpeed;

	}
}
