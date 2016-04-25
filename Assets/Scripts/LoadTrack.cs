using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadTrack : MonoBehaviour {


	public void PlayTrack2(){

		SceneManager.LoadScene ("track02scene");
	}


	public void PlayTrack3(){
		
		SceneManager.LoadScene ("track03scene");
	}
}
