using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBoat : MonoBehaviour {
	private int index = 0;
	void Start () {
		GameObject boats = GameObject.Find ("Boats");
		for (int i = 0; i < boats.transform.childCount; i++) {
			if (boats.transform.GetChild(i).gameObject.activeSelf)
				break;
			index++;
		}		
		boats.transform.GetChild(index).SetParent (gameObject.transform);
		gameObject.transform.GetChild (0).localPosition = new Vector3 (0f, -0.3f, 0f);
		gameObject.transform.GetChild (0).localRotation = Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
