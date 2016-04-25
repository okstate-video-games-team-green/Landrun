using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ListenForRestart : MonoBehaviour {

	//TODO: XBox game stuff

	public KeyCode pauseKey;
	public GameObject restartMenu;
	public TrackState trackState;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (pauseKey)) {
			restartMenu.SetActive(true);
			trackState.PauseRace ();
		}
	}

	public void CloseRestartMenu() {
		restartMenu.SetActive (false);
		trackState.UnpauseRace ();
	}

	public void Restart() {
		SceneManager.LoadScene ("mainScene");
	}

	public void Quit() {
		Application.Quit ();
	}
}
