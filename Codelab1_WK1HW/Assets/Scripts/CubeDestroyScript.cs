using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyScript : MonoBehaviour {

	public float radius = 10f;
	GameObject player1;
	GameObject player2;

	void Start () {
		player1 = GameObject.Find ("Player1");
		player2 = GameObject.Find ("Player2");
	}
	
	void Update () {
		//		goal.transform.position
		//		transform.position
		//Debug.Log(Vector3.Distance(player1.transform.position, transform.position));
		if(Vector3.Distance(player1.transform.position, transform.position) < radius){
				Destroy(gameObject);
				//Debug.Log(gameObject.name + " DIED!!! OH NOOO!!!!");
		}

		if(Vector3.Distance(player2.transform.position, transform.position) < radius){
			Destroy(gameObject);
			//Debug.Log(gameObject.name + " DIED!!! OH NOOO!!!!");
		}
	}
}
