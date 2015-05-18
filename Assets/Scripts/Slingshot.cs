using UnityEngine;
using System.Collections;

public class Slingshot : MonoBehaviour {

	public GameObject LaunchPoint;

	void Awake(){
		Transform LaunchPointTrans = transform.Find ("LaunchPoint");
		LaunchPoint = LaunchPointTrans.gameObject;
		LaunchPoint.SetActive (false);
}

	void OnMouseEnter(){
		//print ("Yay, the mouse has entered!");
		LaunchPoint.SetActive (true);
	}

	void OnMouseExit(){
		//print ("Yay, the mouse has exit!");
		LaunchPoint.SetActive (false);
	}
}
