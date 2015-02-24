using UnityEngine;
using System.Collections;

public class room1CharacterShirtController : MonoBehaviour {

	public Material[] clothingTopColorTexturesArray = new Material[3];
	
	public int clothingTopColorTexturesArrayMaxAmount;
	public static int clothingTopColorTexturesArraySelection;


	void Start () {
		// Find the max amount of Array and load saved data if it exists.
		clothingTopColorTexturesArrayMaxAmount = clothingTopColorTexturesArray.Length-1;
		clothingTopColorTexturesArraySelection = GameSaveLoad.room1clothingTopColorSaveLoad;

	}
	
	void clothingTopColorTextureSetter(){
		renderer.material = clothingTopColorTexturesArray[clothingTopColorTexturesArraySelection];
		room1CharacterAppearance.clothingTopColor = clothingTopColorTexturesArraySelection;
	}


	// Update is called once per frame
	void Update () {
		clothingTopColorTextureSetter();


	}
}
