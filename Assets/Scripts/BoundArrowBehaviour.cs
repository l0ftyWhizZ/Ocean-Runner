using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoundArrowBehaviour : MonoBehaviour {
	public int scrollSpeed;
	private int index = 0;
	public Material mat;
	public Material mat2;
	Vector2 offset = Vector2.zero;

	void Awake () {
		mat.mainTextureOffset = Vector2.zero;
		mat2.mainTextureOffset = Vector2.zero;
	}
	void Update () {
		offset = new Vector2 (Time.time * scrollSpeed, 0f);

		mat.mainTextureOffset = offset;
		mat2.mainTextureOffset = -offset;
	}
}
