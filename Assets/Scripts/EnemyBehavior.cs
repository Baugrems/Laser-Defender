using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		print ("Trigger");
	}

	void OnCollisionEnter2D (Collision2D col) {

		print ("Collision");
	}
		
}
