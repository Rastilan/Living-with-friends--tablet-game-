using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameSaveLoad : MonoBehaviour {

	public static int room1skincolorSaveLoad;
	public static bool room1CharacterCreatedSaveLoad;
	public static int room1clothingTopColorSaveLoad;
	public static bool room1IsFemaleSaveLoad;
	public static bool room1IsMaleSaveLoad;
	// Use this for initialization
	void Start () {

		Load ();
	}
	
	// Update is called once per frame
	void Update () {
		room1skincolorSaveLoad = room1CharacterAppearance.skinColor;
		room1CharacterCreatedSaveLoad = CharacterCreation.characterCreated;
		room1clothingTopColorSaveLoad = room1CharacterShirtController.clothingTopColorTexturesArraySelection;
		room1IsFemaleSaveLoad = CharacterCreation.isFemale;
		room1IsMaleSaveLoad = CharacterCreation.isMale;
		Save ();
	}

	public void Save()
	{
		if (Input.GetKeyDown (KeyCode.I)) {
						
						BinaryFormatter bf = new BinaryFormatter ();
						FileStream file = File.Create (Application.persistentDataPath + "/NekoNekoSaveInfo.dat");

						PlayerData data = new PlayerData ();
						data.room1skinColorData = room1skincolorSaveLoad;
						data.room1CharacterCreatedData = CharacterCreation.characterCreated;
						data.room1clothingTopColorData = room1CharacterShirtController.clothingTopColorTexturesArraySelection;
						data.room1IsFemaleData = CharacterCreation.isFemale;
						data.room1IsMaleData = CharacterCreation.isMale;
		

						bf.Serialize (file, data);
						file.Close ();
				} 
				
				
		
	}
	public void Load(){
	
				if (File.Exists (Application.persistentDataPath + "/NekoNekoSaveInfo.dat")) {
						BinaryFormatter bf = new BinaryFormatter ();
						FileStream file = File.Open (Application.persistentDataPath + "/NekoNekoSaveInfo.dat", FileMode.Open);
						PlayerData data = (PlayerData)bf.Deserialize (file);
						file.Close ();

						room1skincolorSaveLoad = data.room1skinColorData;
						room1CharacterCreatedSaveLoad = data.room1CharacterCreatedData;
						room1clothingTopColorSaveLoad = data.room1clothingTopColorData;
						room1IsFemaleSaveLoad = data.room1IsFemaleData;
						room1IsMaleSaveLoad = data.room1IsMaleData;
				} else {
						Debug.Log ("There is no Save file to load from");
				}
		}
}
[Serializable]
class PlayerData
{
	public int room1skinColorData;
	public bool room1CharacterCreatedData;
	public int room1clothingTopColorData;
	public bool room1IsFemaleData;
	public bool room1IsMaleData;
	
}

