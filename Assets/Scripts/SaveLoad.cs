using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoad {
	public static List<GameManager> savedGames = new List<GameManager>();
	static void Start () {
		LoadScene ();
	}
	public static void SaveScene () {
		savedGames.Add(GameManager.current);
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");
		bf.Serialize(file, SaveLoad.savedGames);
		file.Close();
	}

	public static void LoadScene () {
		if (File.Exists (Application.persistentDataPath + "/savedGames.gd")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			SaveLoad.savedGames = (List<GameManager>)bf.Deserialize (file);
			file.Close ();
		}
	}
}
