using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoundSpawner : MonoBehaviour {

	[SerializeField] private GameObject[] tilePrefabs;
	public GameObject currentSelectedTile;

	void Start () {
		currentSelectedTile = tilePrefabs [0];
		GameObject firstTile = (GameObject) Instantiate (currentSelectedTile);
		firstTile.transform.position = new Vector3 (0f, 50f, -2750f);
	}
		
	public GameObject SpawnTile () {
		int randomIndex = Random.Range (0, tilePrefabs.Length);
		GameObject newTile = (GameObject)Instantiate (tilePrefabs[randomIndex]);
		return newTile;
	}
}
