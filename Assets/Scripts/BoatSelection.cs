using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSelection : MonoBehaviour {
	public GameObject[] boats;
	public int index = 0;
	// Use this for initialization
	void Start () {
		foreach (GameObject boat in boats) {
			boat.SetActive (false);
		}
		boats [index].SetActive (true);

	}
		
	public void SwitchBoatFunc (int direction) {
		index += direction;
		if (index < 0)
			index = boats.Length - 1;
		else if (index > boats.Length - 1)
			index = 0;
		foreach (GameObject boat in boats) {
			boat.SetActive (false);
		}
		boats [index].SetActive (true);
	}
}
