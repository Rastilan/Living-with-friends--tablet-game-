using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterDialogue : MonoBehaviour {

	public Text chatbox;
	public Image chatboxBackground;


	public string normString;
	public string angryString;
	public string sadString;
	public string sickString;

	List<string> normalDialogueList = new List<string>();
	List<string> angryDialogueList = new List<string>();
	List<string> sadDialogueList = new List<string>();
	List<string> sickDialogueList = new List<string>();




	// Use this for initialization
	void Start () {


		//Add Normal Dialogue Here
		normalDialogueList.Add ("I am Feeling ok!");
		normalDialogueList.Add ("How are you today?");
		normalDialogueList.Add ("This is fine.");
		normalDialogueList.Add ("I wonder when I will be able to have friends.");
		normalDialogueList.Add ("Do you how do?");
		normalDialogueList.Add ("Everything is waffles.");
		normalDialogueList.Add ("YEAH TOAST!");
		normalDialogueList.Add ("I am just a capsule, my emotions are predetermined and emulated through random number generators.");

		normString = normalDialogueList [Random.Range (1, normalDialogueList.Count)];




	}
	
	// Update is called once per frame
	void Update () {
				if (CharacterStatus.mood == "Normal")
						chatbox.text = normString;
				else if (CharacterStatus.mood == "Angry")
						chatbox.text = "I am feeling angry today!";
				else if (CharacterStatus.mood == "Sad")
						chatbox.text = "I am feeling sad today!";
				else if (CharacterStatus.mood == "Sick")
						chatbox.text = "I am feeling sick today!";

		}
	
}
