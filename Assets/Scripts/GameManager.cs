using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameManager : MonoBehaviour {
	public static GameManager current;
	public int currentCoins;

	public GameManager () {
		currentCoins = new int ();
	}

}
