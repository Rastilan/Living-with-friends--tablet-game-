using UnityEngine;
using System.Collections;

public class room1HairController : MonoBehaviour {

	public GameObject newHair;
	public GameObject currentHair;
	public GameObject femaleResident;
	public GameObject newHairInstance;

	public GameObject[] hairGameObjectArray = new GameObject[2];
	
	public int hairGameObjectArrayMaxAmount;
	public int hairGameObjectArraySelection;

	// Use this for initialization
	void Start () {
		hairGameObjectArrayMaxAmount = hairGameObjectArray.Length - 1;
		femaleResident = GameObject.FindGameObjectWithTag ("Resident");
		currentHair = GameObject.FindGameObjectWithTag ("Hair");	
	}
	
	// Update is called once per frame
	void Update () {
		SelectNewHair ();
		ReplaceHair ();
	
	}

	void SelectNewHair()
	{
				if (Input.GetKeyDown (KeyCode.U)) {
						if (hairGameObjectArraySelection >= hairGameObjectArrayMaxAmount)
								hairGameObjectArraySelection = 0;
						else
								hairGameObjectArraySelection++;
			
				}
				if (Input.GetKeyDown (KeyCode.Y)) {
						if (hairGameObjectArraySelection == 0)
								hairGameObjectArraySelection = hairGameObjectArrayMaxAmount;
						else
								hairGameObjectArraySelection--;
				}
		}

	void ReplaceHair()
	{
		newHair = hairGameObjectArray [hairGameObjectArraySelection];
		if (Input.GetKeyDown (KeyCode.O)) {
			newHairInstance = Instantiate(newHair) as GameObject;
			currentHair = GameObject.FindGameObjectWithTag ("Hair");
						// set position
						newHairInstance.transform.position = currentHair.transform.position;
		
						// set rotation
						newHairInstance.transform.rotation = currentHair.transform.rotation;
		
						// set scale
						newHairInstance.transform.localScale = currentHair.transform.localScale;
			newHairInstance.transform.parent = femaleResident.transform;
								Destroy (currentHair);
		
				}
		//currentHairTransform.transform.parent.gameObject = femaleResident.transform.gameObject;
	}
}


