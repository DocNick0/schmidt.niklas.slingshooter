using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
		
		if (col.gameObject.tag == "Projectile" || col.gameObject.tag == "Brick" || col.gameObject.tag == "TNT") {
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "TNT") {
			Application.LoadLevel ("Level1");
		}
	}
}