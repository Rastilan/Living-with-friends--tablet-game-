using UnityEngine;
using System.Collections;

public class CharacterSelectedScript : MonoBehaviour {

	public GameObject ResidentObject;
	public Transform camera;
	public int moveSpeed;
	public int rotationSpeed;
	private Transform myTransform;

	void Awake(){
				myTransform = transform;
		}
	void Start(){

		}

	void Update () {
		Debug.DrawLine (camera.position, myTransform.position, Color.yellow);
		
		//Look at Target

		//Move to Target
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

		if (CharacterCreation.characterIsBeingCreated == true) {
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation(camera.position - myTransform.position), rotationSpeed * Time.deltaTime);
				}
	}

	private void OnMouseDown()
	{
		Debug.Log ("CHARACTERS SELECTED");
		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation(camera.position - myTransform.position), rotationSpeed * Time.deltaTime);

	}
	
}
