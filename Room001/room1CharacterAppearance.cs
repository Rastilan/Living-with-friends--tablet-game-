using UnityEngine;
using System.Collections;

public class room1CharacterAppearance : MonoBehaviour {

	public Material[] skinColorTexturesArray = new Material[3];

	public int skinColorTexturesArrayMaxAmount;
	public static int skinColorTexturesArraySelection;
	public static int skinColor;
	public static int clothingTop;
	public static int clothingBottom;
	public static int clothingTopColor;
	public static int clothingBottomColor;
	public static int hairType;
	public static int hairColor;
	public static int eyebrowType;
	public static int eyebrowColor;
	public static int eyeType;
	public static int eyeColor;
	public static int sockType;
	public static int sockColor;
	public static int shoeType;
	public static int shoeColor;

	// Use this for initialization
	void Start () {
		skinColorTexturesArrayMaxAmount = skinColorTexturesArray.Length-1;
		skinColorTexturesArraySelection = GameSaveLoad.room1skincolorSaveLoad;
	}
	
	public void SkinColorTextureSetter()
	{
		clothingTopColor = room1CharacterShirtController.clothingTopColorTexturesArraySelection;
		renderer.material = skinColorTexturesArray[skinColorTexturesArraySelection];
		skinColor = skinColorTexturesArraySelection;
		}
	
	// Update is called once per frame
	void Update () {
			SkinColorTextureSetter();

	}
}
