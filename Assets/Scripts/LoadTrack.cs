using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LoadTrack : MonoBehaviour {

	public Slider character;
	public GameObject player;
	public GameObject BeardmanPrefab;
	public GameObject PioneerWomanPrefab;
	public GameObject cowboyPrefab;
	public static float characterSelected;






	public void characterCheck(){

		if (character.value == 1) 
			Instantiate (cowboyPrefab);




		if (character.value == 2) 
			Instantiate (BeardmanPrefab);


		if (character.value == 3)
			Instantiate (PioneerWomanPrefab);

	}



	public void PlayTrack2(){
		
		characterSelected = character.value;
		SceneManager.LoadScene ("track02scene");


	}


	public void PlayTrack3(){
		

		characterSelected = character.value;
		SceneManager.LoadScene ("track03scene");
	}




}
