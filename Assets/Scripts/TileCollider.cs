using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollider : MonoBehaviour {
	[SerializeField] private GameObject boundSpawner;
	private bool hasCrossed = false;
	public void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag.Equals ("Player") && !hasCrossed) {
			// Spawn the next prefab.
			GameObject newTile = boundSpawner.GetComponent<BoundSpawner>().SpawnTile();
			newTile.transform.position = boundSpawner.GetComponent<BoundSpawner>().currentSelectedTile.transform.position;
			newTile.transform.position += new Vector3 (boundSpawner.GetComponent<BoundSpawner> ().currentSelectedTile.GetComponent<TileParams> ().xOffset, 
													   boundSpawner.GetComponent<BoundSpawner> ().currentSelectedTile.GetComponent<TileParams> ().yOffset, 
													   boundSpawner.GetComponent<BoundSpawner> ().currentSelectedTile.GetComponent<TileParams> ().zOffset);
			boundSpawner.GetComponent<BoundSpawner> ().currentSelectedTile = newTile;
			hasCrossed = true;
		}
	}
}
