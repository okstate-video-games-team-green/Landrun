using UnityEngine;
using System.Collections;

public class CharacterPicker : MonoBehaviour {

	public static int characterSelected;
	public GameObject BeardmanPrefab;
	public GameObject PioneerWomanPrefab;
	public GameObject cowboyPrefab;


	// Use this for initialization
	void Start () {
	
		if (characterSelected ==1)
			Instantiate (cowboyPrefab);
		
		if (characterSelected ==2)
			Instantiate (BeardmanPrefab);
		

		if (characterSelected ==3)
			Instantiate (PioneerWomanPrefab);
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
