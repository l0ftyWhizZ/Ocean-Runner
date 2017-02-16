using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeSceneFunc (string name) {
		GameObject boatHolder = GameObject.Find ("Boat").transform.GetChild (1).gameObject;
		boatHolder.transform.SetParent (null);
		DontDestroyOnLoad (boatHolder);
		SceneManager.LoadScene (name);
	}

	public void Quit () {
		Application.Quit ();
	}
}
