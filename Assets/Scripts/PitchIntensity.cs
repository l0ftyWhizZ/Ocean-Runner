using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchIntensity : MonoBehaviour {

	[SerializeField]
	private float pitchFactor;

	[SerializeField]
	private int incrementDuration;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((int)Time.timeSinceLevelLoad % incrementDuration == 0 && pitchFactor <= 1) {
			pitchFactor += Time.fixedDeltaTime / 20f;
		}

		GetComponent<AudioSource> ().pitch = Mathf.Clamp(pitchFactor, 0.8f, 1f);
	}
}
