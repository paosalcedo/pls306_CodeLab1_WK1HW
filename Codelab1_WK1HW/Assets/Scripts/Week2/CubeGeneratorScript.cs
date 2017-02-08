using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGeneratorScript : MonoBehaviour {

	public GameObject cube;
	public float timeUntilCubeSpawn;
	//GameObject player;

	void Start () {
		timeUntilCubeSpawn = 0.5f;
		//player = GameObject.Find ("Player1");
	}

	void Update () {

		timeUntilCubeSpawn -= Time.deltaTime;
		//instantiate cube every x seconds only when player is pressing a direction, to prevent cube being layed on same place.
		if (timeUntilCubeSpawn <= 0f) {
			Instantiate (cube, transform.position, transform.rotation);
			timeUntilCubeSpawn = 0.5f;
		}
	}
}
