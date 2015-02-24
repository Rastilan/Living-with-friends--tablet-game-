using UnityEngine;
using System.Collections;

public class IslandSelectScreenHouseSelection : MonoBehaviour {

	public bool currentlyOccupied = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		if (currentlyOccupied == true)
		{
						Application.LoadLevel ("Room001");
		}
	else
	{
		Debug.Log("Creating character");
	}
}
}
