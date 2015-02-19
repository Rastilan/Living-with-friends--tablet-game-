using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour {

	public static bool characterCreated = false;
	public static bool characterIsBeingCreated = true;
	public static bool genderSelected = false;
	public GameObject femaleResident;
	public GameObject maleResident;

	// Use this for initialization
	void Start () {
		characterCreated = GameSaveLoad.room1CharacterCreatedSaveLoad;
		isFemale = GameSaveLoad.room1IsFemaleSaveLoad;
		isMale = GameSaveLoad.room1IsMaleSaveLoad;
		characterIsBeingCreated = true;
		if (characterCreated == true) {
			maleButtonBackground.enabled = false;
			maleButtonText.enabled = false;
			femaleButtonBackground.enabled = false;
			femaleButtonText.enabled = false;

			
			characterCreationGenderSelectionBackground.enabled = false;
			characterCreationGenderSelectionCancelButton.enabled = false;
			characterCreationGenderSelectionCancelButtonText.enabled = false;
			characterCreationGenderSelectionSelectAGenderText.enabled = false;
			characterIsBeingCreated = false;
			if (isFemale == true) {
				IsFemale ();
			}
			else if (isMale == true) {
				IsMale ();
			}
			else
				Debug.Log ("No gender found in the character creation if/then statement");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IsFemale()
	{
		isFemale = true;
		maleButtonBackground.enabled = false;
		maleButtonText.enabled = false;
		femaleButtonBackground.enabled = false;
		femaleButtonText.enabled = false;
		Instantiate(femaleResident);
		characterCreationGenderSelectionBackground.enabled = false;
		characterCreationGenderSelectionCancelButton.enabled = false;
		characterCreationGenderSelectionCancelButtonText.enabled = false;
		characterCreationGenderSelectionSelectAGenderText.enabled = false;
		genderSelected = true;
	}
	
	public void IsMale()
	{
		isMale = true;
		maleButtonBackground.enabled = false;
		maleButtonText.enabled = false;
		femaleButtonBackground.enabled = false;
		femaleButtonText.enabled = false;
		Instantiate(maleResident);
		characterCreationGenderSelectionBackground.enabled = false;
		characterCreationGenderSelectionCancelButton.enabled = false;
		characterCreationGenderSelectionCancelButtonText.enabled = false;
		characterCreationGenderSelectionSelectAGenderText.enabled = false;
		genderSelected = true;
	}
}
