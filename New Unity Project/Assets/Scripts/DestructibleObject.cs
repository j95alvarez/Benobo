using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour {
    
    public int hp { get; set; }

	// Use this for initialization
	void Start () {
        // testing
        hp = 1;
	}
	
	// Update is called once per frame
	void Update () {
        // If all health is lost, destroy itself
		if (hp == 0) {
            Destroy(gameObject);
        }
	}
}
