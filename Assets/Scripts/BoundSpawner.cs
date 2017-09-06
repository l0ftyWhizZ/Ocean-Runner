using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoundSpawner : MonoBehaviour {

	[SerializeField] private GameObject[] tilePrefabs;
	public GameObject currentSelectedTile;

	private Vector3 eulerAngles = Vector3.zero;

	void Start () {
		GameObject firstTile = (GameObject)Instantiate (tilePrefabs [0]);
		firstTile.transform.position = new Vector3 (0f, 50f, -1750f);
		currentSelectedTile = firstTile;
		StartCoroutine (WaitBeforeSpawn (5f));
	}
		
	public void SpawnTile () {
		int randomIndex = Random.Range (0, tilePrefabs.Length);
		GameObject newTile = (GameObject)Instantiate (tilePrefabs[randomIndex]);
		Destroy (newTile, 20f);
		newTile.transform.position = currentSelectedTile.transform.GetChild(2).position;

		eulerAngles = newTile.transform.rotation.eulerAngles;
		eulerAngles += new Vector3(0f, currentSelectedTile.GetComponent<TileParams> ().yRotationOffset, 0f);
		newTile.transform.rotation = Quaternion.Euler (eulerAngles);
		newTile.GetComponent<TileParams> ().yRotationOffset = (int) newTile.transform.rotation.eulerAngles.y;
		currentSelectedTile = newTile;
	}

	IEnumerator WaitBeforeSpawn (float seconds) {
		yield return new WaitForSeconds (seconds);
		InvokeRepeating ("SpawnTile", 0f, 10f);
	}
}
