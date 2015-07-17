using UnityEngine;
using System.Collections;

public class TNT : MonoBehaviour {

	public GameObject explosion;


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Pig") {

			Instantiate (explosion, transform.position, transform.rotation);
			
			Destroy (gameObject);

		}
	}

}
