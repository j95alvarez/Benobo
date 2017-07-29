using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espawner : MonoBehaviour {
	public GameObject enemy;
	private float timer;
	// Use this for initialization
	void Start () { 
		timer = 0;
		
	}
	
	// Update is called once per frame

	void Update () {
		timer += Time.deltaTime;
		if (timer > 5) {
			Instantiate (enemy, new Vector3 (Random.Range (5, 20), Random.Range (5, 20), 0), Quaternion.identity);
			timer = 0;
		}
	}
}
