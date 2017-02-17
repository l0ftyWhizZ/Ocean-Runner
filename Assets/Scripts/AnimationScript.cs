using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationScript : MonoBehaviour {

	public ShopScript shop;
	public bool doneRotation = false;
	public bool rotated = false;
	public int directionOfRotation;
	// Use this for initialization
	void Start () {
		
	}

	public void RotateUI (int dir) {
		rotated = true;
		directionOfRotation = dir;
	}
		
	// Update is called once per frame
	void Update () {
		if (rotated) {
			foreach (GameObject ui in shop.componentsToDisable) {
				ui.transform.eulerAngles = Vector3.Lerp(ui.transform.rotation.eulerAngles, Vector3.up * 90f * directionOfRotation, Time.deltaTime * 5);
				if (Mathf.Abs(ui.transform.eulerAngles.y - 90f) <= 1f ) {
					doneRotation = true;
					rotated = false;
				}
				if ((directionOfRotation == 0 && Mathf.Abs(ui.transform.eulerAngles.y) <= 1f)) {
					rotated = false;
				}
			}
		}
	}
}
