using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioChooser : MonoBehaviour {

	[SerializeField]
	private AudioClip[] audioClips;

	private int index;
	// Use this for initialization
	void Awake () {
		index = Random.Range (0, audioClips.Length);
		GetComponent<AudioSource> ().clip = audioClips [index];
		GetComponent<AudioSource>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
