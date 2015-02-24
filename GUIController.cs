using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {

	public Text chatbox;
	public Image chatboxBackground;
	public Image skinColorPanel;
	public Image skinColorOne;
	public Image skinColorTwo;
	public Image skinColorThree;


	public bool editResidentButtonOpen;
	public Image shirtColorPanel;
	public Image shirtColorOne;
	public Image shirtColorTwo;
	public Image shirtColorThree;

	public Image nameInputField;
	public Text nameInputFieldText;
	public Text nameInputFieldPlaceholderText;
	public Image editResidentButton;
	public Text editResidentButtonText;
	// Use this for initialization
	void Start () {
				skinColorPanel.enabled = false;
				skinColorOne.enabled = false;
				skinColorTwo.enabled = false;
				skinColorThree.enabled = false;
				shirtColorOne.enabled = false;
				shirtColorPanel.enabled = false;
				shirtColorTwo.enabled = false;
				shirtColorThree.enabled = false;
				nameInputField.enabled = false;
				nameInputFieldText.enabled = false;
				nameInputFieldPlaceholderText.enabled = false;

				if (CharacterCreation.characterCreated == false) {
						editResidentButton.enabled = false;
						editResidentButtonText.enabled = false;
				}
		}


	// Update is called once per frame
	void Update () {

		if (CharacterCreation.characterCreated == true) {
				}
			if (CharacterCreation.characterCreated == true) {
				chatbox.enabled = true;
				chatboxBackground.enabled = true;
			} else if (CharacterCreation.characterCreated == false) { 
				chatbox.enabled = false;
				chatboxBackground.enabled = false;
			} else {
				Debug.Log ("Chatbox bugged, character creation neither true or false!");
			}
			
		}

	public void SkinControlPanelController(){

		skinColorPanel.enabled = !skinColorPanel.enabled;
		skinColorOne.enabled = !skinColorOne.enabled;
		skinColorTwo.enabled = !skinColorTwo.enabled;
		skinColorThree.enabled = !skinColorThree.enabled;
		shirtColorOne.enabled = false;
		shirtColorTwo.enabled = false;
		shirtColorThree.enabled = false;
		shirtColorPanel.enabled = false;

	}

	public void shirtColorButtonController(){
		shirtColorPanel.enabled = !shirtColorPanel.enabled;
		shirtColorOne.enabled = !shirtColorOne.enabled;
		shirtColorTwo.enabled = !shirtColorTwo.enabled;
		shirtColorThree.enabled = !shirtColorThree.enabled;
		skinColorPanel.enabled = false;
		skinColorOne.enabled = false;
		skinColorTwo.enabled = false;
		skinColorThree.enabled = false;

		}
	public void EditResidentButton(){
		editResidentButtonOpen = !editResidentButtonOpen;
				if (editResidentButtonOpen == false) {
	
			shirtColorPanel.enabled = false;
			shirtColorOne.enabled = false;
			shirtColorTwo.enabled = false;
			shirtColorThree.enabled = false;

			skinColorOne.enabled = false;
			skinColorTwo.enabled = false;
			skinColorThree.enabled = false;
			skinColorPanel.enabled = false;
				} else if (editResidentButtonOpen == true) {



				}
		}

}
