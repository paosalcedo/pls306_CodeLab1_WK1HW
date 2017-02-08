using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyScript : MonoBehaviour {

	GameObject ball;
	GameObject player2;
	GameObject player1;
	GameObject goal2;

	//GameObject goal2;
	public float radius = 5f;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("TheBall");
		player2 = GameObject.Find ("Player2");
		goal2 = GameObject.Find ("Goal2");
		player1 = GameObject.Find ("Player1");
		player2.SetActive (true);
		player1.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {	
		//find distance between goals and ball. 
		//if ball is closer to own goal, other player (player 2 here) dies.
		if(Vector3.Distance(ball.transform.position, transform.position) < radius){
			player2.SetActive (false);
			Debug.Log(player2.name + " DIED!!! OH NOOO!!!!");
		} 

		if(Vector3.Distance(ball.transform.position, goal2.transform.position) < radius){
			player1.SetActive (false);
			Debug.Log(player1.name + " DIED!!! OH NOOO!!!!");
		} 


	}
}
