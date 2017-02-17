using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour {
	public GameObject[] componentsToDisable;

	[SerializeField]
	private AnimationScript animationScript;

	public bool goBack = false;
	// Use this for initialization
	public void OnClick () {
		animationScript.RotateUI (1);
	}

	public void goBackToMenu() {
		animationScript.doneRotation = false;
		animationScript.RotateUI (0);
		goBack = true;
	}

	void Update () {
		if (animationScript.doneRotation) {
			foreach (GameObject obj in componentsToDisable) {
				obj.SetActive (false);
			}
			transform.GetChild (1).gameObject.SetActive (true);
		}

		if (goBack) {
			foreach (GameObject obj in componentsToDisable) {
				obj.SetActive (true);
			}
			transform.GetChild (1).gameObject.SetActive (false);
			goBack = false;
		}
	}
}
