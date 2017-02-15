using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAnimation : MonoBehaviour {

	[SerializeField]
	private float duration;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<RectTransform> ().localScale = new Vector3 (Mathf.Clamp(Mathf.Abs(Mathf.Sin (Time.timeSinceLevelLoad / duration)), 0.7f, 1f), Mathf.Clamp(Mathf.Abs(Mathf.Sin (Time.timeSinceLevelLoad / duration)), 0.7f, 1f), 0f);
		GetComponent<Image> ().color = new Color (Mathf.Sin (Time.timeSinceLevelLoad * duration), Mathf.Cos (Time.timeSinceLevelLoad * duration), Mathf.Sin (Time.timeSinceLevelLoad * duration), 1f);
	}
}
