using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	// Static field accessible from anywhere
	// Storing if the goal was met
	public static bool goalMet = false;

	public GameObject prefabGoalDead;

	private GameObject goalDead;

	public GameObject explosion;
	

	// Trigger got entered
	void OnTriggerEnter(Collider other) {
		// Check if the object entering the trigger is a tnt
		if(other.gameObject.tag == "TNT") {

			goalMet = true;

			Instantiate (prefabGoalDead, gameObject.transform.position, gameObject.transform.rotation);

			Instantiate (explosion, transform.position, transform.rotation);

			Destroy (this.gameObject);


		}
	
	}


}
