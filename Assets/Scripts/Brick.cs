using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	

	public float Health = 100f;

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "Projectile") {

		float damage = col.gameObject.GetComponent<Rigidbody> ().velocity.magnitude * 10;

		//decrease health according to magnitude of object that hits brick
		Health -= damage;

		//if health is 0, destroy brick
		if (Health <= 0)

			Destroy (this.gameObject);
		}

	}
}