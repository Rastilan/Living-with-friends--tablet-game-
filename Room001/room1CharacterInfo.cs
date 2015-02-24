using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class room1CharacterInfo : MonoBehaviour {

	public string characterName;
	public Text characterNameInput;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (characterName);
		characterName = characterNameInput.text;
	
	}
}
