using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public int speed;
    public int hp;
    public GameObject playerBase;

	// Use this for initialization
	void Start () {
        playerBase = GameObject.FindGameObjectWithTag("Base");	
	}
	
	// Update is called once per frame
	void Update () {
        if (playerBase != null) {
            transform.position = Vector3.MoveTowards(transform.position, playerBase.transform.position, speed * Time.deltaTime);
        }

	}

    // If we attack the base, it takes a point of damage
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Base") {
            coll.gameObject.GetComponent<DestructibleObject>().hp--;
        }
    }
}
