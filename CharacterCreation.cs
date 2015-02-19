using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour {

	//-----------------------------------------------Base buttons------------------------------------------------------
	public Image raceButton;
	public Text raceButtonText;
	public Image genderButton;
	public Text genderButtonText;
	public Image headButton;
	public Text headButtonText;
	public Image torsoButton;
	public Text torsoButtonText;
	public Image legsButton;
	public Text legsButtonText;
	public Image featuresButton;
	public Text featuresButtonText;

	//----------------------------------------------Base panel controllers----------------------------------------------
	//Race controllers
	public Image raceBackgroundPanel;
	public Image raceButtonHuman;
	public Text raceButtonHumanText;

	//Gender controllers
	public Image genderBackgroundPanel;
	public Image genderButtonMale;
	public Text genderButtonMaleText;
	public Image genderButtonFemale;
	public Text genderButtonFemaleText;

	//character Creation player set variables
	public static bool isFemale;
	public static bool isMale;

	public static bool characterCreated = false;
	public static bool characterIsBeingCreated = true;
	public static bool genderSelected = false;
	public GameObject femaleResident;
	public GameObject maleResident;

	// Use this for initialization
	void Start () {

		raceBackgroundPanel.enabled = false;
		raceButtonHuman.enabled = false;
		raceButtonHumanText.enabled = false;
		characterIsBeingCreated = true;
		if (characterCreated == true) {

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
		Instantiate(femaleResident);
		genderSelected = true;
	}
	
	public void IsMale()
	{
		isMale = true;
		Instantiate(maleResident);
		genderSelected = true;
	}

	public void raceButtonController()
	{
		raceBackgroundPanel.enabled = !raceBackgroundPanel.enabled;
		raceButtonHuman.enabled = !raceButtonHuman.enabled;
		raceButtonHumanText.enabled = !raceButtonHumanText.enabled;
	}

	public void genderButtonController()
	{
		genderBackgroundPanel.enabled = !genderBackgroundPanel.enabled;
	}
}
