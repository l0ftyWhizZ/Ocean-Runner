using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour {
	[SerializeField]
	private Transform boat;

	[SerializeField]
	private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (boat.transform.position, boat.transform.up, speed * Time.fixedDeltaTime);
		transform.position += new Vector3 (0f, 0f, Mathf.Sin(Time.timeSinceLevelLoad) * 0.1f);
	}
}
