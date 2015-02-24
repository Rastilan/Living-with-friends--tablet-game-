using UnityEngine;
using System.Collections;

public class room1ShirtColorPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ShirtColorOne(){
		room1CharacterShirtController.clothingTopColorTexturesArraySelection = 0;
	}
	public void ShirtColorTwo(){
		room1CharacterShirtController.clothingTopColorTexturesArraySelection = 1;
	}
	public void shirtColorThree(){
		room1CharacterShirtController.clothingTopColorTexturesArraySelection = 2;
	}

}
