using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour {
	[SerializeField]
	private GameObject[] componentsToDisable;
	// Use this for initialization
	public void OnClick () {
		foreach (GameObject obj in componentsToDisable) {
			obj.SetActive (false);
		}

		transform.GetChild (1).gameObject.SetActive (true);
	}

	public void goBackToMenu() {
		foreach (GameObject obj in componentsToDisable) {
			obj.SetActive (true);
		}

		transform.GetChild (1).gameObject.SetActive (false);
	}

	void Update () {

	}
}
