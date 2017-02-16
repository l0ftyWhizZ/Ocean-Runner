using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBoat : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject boat = GameObject.Find ("Boats");
		boat.transform.SetParent (gameObject.transform);
	}
}
