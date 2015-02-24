using UnityEngine;
using System.Collections;

/// <summary>
/// Creates wandering behaviour for a CharacterController.
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class Wander : MonoBehaviour
{
	public float speed = 0.8f;
	public float directionChangeInterval = 5;
	public float maxHeadingChange = 359;
	
	CharacterController controller;
	float heading;
	Vector3 targetRotation;
	public GameObject ResidentObject;
	public Transform mainCamera;
	public int moveSpeed;
	public int rotationSpeed;
	private Transform myTransform;
	public bool residentSelected = false;
	public Transform characterCreationStareAtThis;
	
	void Awake ()
	{
			myTransform = transform;
		controller = GetComponent<CharacterController>();
		
		// Set random initial rotation
		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);
		
		StartCoroutine(NewHeading());
	}
	void Start(){

	}
	
	void Update ()
	{
		
		//Move to Target
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

		Debug.DrawRay(transform.position, transform.forward * 10, Color.red);

		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * speed);

		if (residentSelected == true) {
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (mainCamera.position - myTransform.position), rotationSpeed * Time.deltaTime);
						speed = 0;
						directionChangeInterval = 0;
						maxHeadingChange = 0;
				} else {
			residentSelected = false;
				}
		if (CharacterCreation.characterIsBeingCreated == true) {
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (characterCreationStareAtThis.position - myTransform.position), rotationSpeed * Time.deltaTime);
			speed = 0;
			directionChangeInterval = 0;
			maxHeadingChange = 0;
			myTransform.position = new Vector3(0, 2, -5);
			residentSelected = false;
				} else
						residentSelected = false;
	}
	
	/// <summary>
	/// Repeatedly calculates a new direction to move towards.
	/// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.
	/// </summary>
	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}
	
	/// <summary>
	/// Calculates a new direction to move towards.
	/// </summary>
	void NewHeadingRoutine ()
	{
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}
	private void OnMouseDown()
	{
		Debug.Log ("CHARACTERS SELECTED");
		residentSelected = true;

	}


}