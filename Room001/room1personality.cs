using UnityEngine;
using System.Collections;

public class room1personality : MonoBehaviour {

	public static int movementPersonality;
	public static int speechPersonality;
	public static int expressivenessPersonality;
	public static int attitudePersonality;
	public static int overallPersonality;
	public int movementPersonalityMax = 8;
	public int speechPersonalityMax = 8;
	public int expressivenessPersonalityMax = 8;
	public int attitudePersonalityMax = 8;
	public int overallPersonalityMax = 8;
	public int movementPersonalityMin = 1;
	public int speechPersonalityMin = 1;
	public int expressivenessPersonalityMin = 1;
	public int attitudePersonalityMin = 1;
	public int overallPersonalityMin = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (movementPersonality > movementPersonalityMax) {
						movementPersonality = movementPersonalityMax;
				} else if (speechPersonality > speechPersonalityMax) {
						speechPersonality = speechPersonalityMax;
				} else if (expressivenessPersonality > expressivenessPersonalityMax) {
						expressivenessPersonality = expressivenessPersonalityMax;
				} else if (attitudePersonality > attitudePersonalityMax) {
						attitudePersonality = attitudePersonalityMax;
				} else if (overallPersonality > overallPersonalityMax) {
						overallPersonality = overallPersonalityMax;
				} else if (movementPersonality < movementPersonalityMin) {
						movementPersonality = movementPersonalityMin;
				} else if (speechPersonality < speechPersonalityMin) {
						speechPersonality = speechPersonalityMin;
				} else if (expressivenessPersonality < expressivenessPersonalityMin) {
						expressivenessPersonality = expressivenessPersonalityMin;
				} else if (attitudePersonality < attitudePersonalityMin) {
						attitudePersonality = attitudePersonalityMin;
				} else if (overallPersonality < overallPersonalityMin) {
						overallPersonality = overallPersonalityMin;
				} else 
						Debug.Log ("Something went horribly wrong with room1's personality.. psycho detected!");
	
	}
}
