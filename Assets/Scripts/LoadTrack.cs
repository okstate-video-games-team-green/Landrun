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



	public void PlayTrack2(){
		
		SceneManager.LoadScene ("track02scene");
	}


	public void PlayTrack3(){
		
		SceneManager.LoadScene ("track03scene");
	}



	public void characterCheck(){

		if (character.value == 1) 
			Instantiate (cowboyPrefab);
		



		if (character.value == 2) 
			Instantiate (BeardmanPrefab);
		

		if (character.value == 3)
				Instantiate (PioneerWomanPrefab);

	}

}
