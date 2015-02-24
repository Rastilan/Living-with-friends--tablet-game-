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

	//character creation gender selection
	public static bool isFemale;
	public static bool isMale;

	//character head selection
	public Image headBackgroundPanel;
	public Image headButton1;
	public Text headButton1Text;
	public Image headButton2;
	public Text headButton2Text;

	//character torso selection
	public Image torsoBackgroundPanel;
	public Image torsoButton1;
	public Text torsoButton1Text;
	public Image torsoButton2;
	public Text torsoButton2Text;

	//character legs selection
	public Image legsBackgroundPanel;
	public Image legsButton1;
	public Text legsButton1Text;
	public Image legsButton2;
	public Text legsButton2Text;

	//character features selection

	public Image featuresBackgroundPanel;
	//Features should be fleshed out and named after the specific feature selections beards/piercing selection etc.

	//controllers to enable or disable character creation upon entering a scene with or without a resident
	public static bool characterCreated = false;
	public static bool characterIsBeingCreated = true;
	public GameObject femaleResident;
	public GameObject maleResident;
	public GameObject currentResident;
	// Use this for initialization
	void Start () {
		CharacterCreaterUIController ();
	


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
		currentResident = GameObject.FindGameObjectWithTag ("Resident");
	
	}

	public void IsFemale()
	{
		isFemale = true;
		Instantiate(femaleResident);
		Destroy (currentResident);
		isMale = false;

	}
	
	public void IsMale()
	{
		isMale = true;
		Instantiate(maleResident);
		Destroy (currentResident);
		isFemale = false;

	}

	public void RaceButtonController()
	{
		raceBackgroundPanel.enabled = !raceBackgroundPanel.enabled;
		raceButtonHuman.enabled = !raceButtonHuman.enabled;
		raceButtonHumanText.enabled = !raceButtonHumanText.enabled;
		//more races to be added later

	}

	public void GenderButtonController()
	{
		genderBackgroundPanel.enabled = !genderBackgroundPanel.enabled;
		genderButtonFemale.enabled = !genderButtonFemale.enabled;
		genderButtonFemaleText.enabled = !genderButtonFemaleText.enabled;
		genderButtonMale.enabled = !genderButtonMale.enabled;
		genderButtonMaleText.enabled = !genderButtonMaleText.enabled;
	}

	public void HeadButtonController()
	{
		headBackgroundPanel.enabled = !headBackgroundPanel.enabled;
		headButton1.enabled = !headButton1.enabled;
		headButton1Text.enabled = !headButton1Text.enabled;
		headButton2.enabled = !headButton2.enabled;
		headButton2Text.enabled = !headButton2Text.enabled;
	}

	public void TorsoButtonController()
	{
		torsoBackgroundPanel.enabled = !torsoBackgroundPanel.enabled;
		torsoButton1.enabled = !torsoButton1.enabled;
		torsoButton1Text.enabled = !torsoButton1Text.enabled;
		torsoButton2.enabled = !torsoButton2.enabled;
		torsoButton2Text.enabled = !torsoButton2Text.enabled;
	}

	public void LegsButtonController()
	{
		legsBackgroundPanel.enabled = !legsBackgroundPanel.enabled;
		legsButton1.enabled = !legsButton1.enabled;
		legsButton1Text.enabled = !legsButton1Text.enabled;
		legsButton2.enabled = !legsButton2.enabled;
		legsButton2Text.enabled = !legsButton2Text.enabled;
	}

	public void FeaturesButtonController()

	{
		featuresBackgroundPanel.enabled = !featuresBackgroundPanel.enabled;

		//more stuff will go here after this is more to be added!!
	}

	public void CharacterCreaterUIController()
	{

		raceBackgroundPanel.enabled = false;
		raceButtonHuman.enabled = false;
		raceButtonHumanText.enabled = false;
		genderBackgroundPanel.enabled = false;
		genderButtonMale.enabled = false;
		genderButtonMaleText.enabled = false;
		genderButtonFemale.enabled = false;
		genderButtonFemaleText.enabled = false;
		headBackgroundPanel.enabled = false;
		headButton1.enabled = false;
		headButton1Text.enabled = false;
		headButton2.enabled = false;
		headButton2Text.enabled = false;
		torsoBackgroundPanel.enabled = false;
		torsoButton1.enabled = false;
		torsoButton1Text.enabled = false;
		torsoButton2.enabled = false;
		torsoButton2Text.enabled = false;
		legsBackgroundPanel.enabled = false;
		legsButton1.enabled = false;
		legsButton1Text.enabled = false;
		legsButton2.enabled = false;
		legsButton2Text.enabled = false;

		if (characterCreated == true) {
						raceButton.enabled = false;
						raceButtonText.enabled = false;
						genderButton.enabled = false;
						genderButtonText.enabled = false;
						headButton.enabled = false;
						headButtonText.enabled = false;
						torsoButton.enabled = false;
						torsoButtonText.enabled = false;
						legsButton.enabled = false;
						legsButtonText.enabled = false;
						featuresButton.enabled = false;
						featuresButtonText.enabled = false;

				}
			else 
		{
			raceButton.enabled = true;
			raceButtonText.enabled = true;
			genderButton.enabled = true;
			genderButtonText.enabled = true;
			headButton.enabled = true;
			headButtonText.enabled = true;
			torsoButton.enabled = true;
			torsoButtonText.enabled = true;
			legsButton.enabled = true;
			legsButtonText.enabled = true;
			featuresButton.enabled = true;
			featuresButtonText.enabled = true;

		}
	}

}
