using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UI : MonoBehaviour {
	public Text timeT;
	public TrackState trackState;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (trackState.inProgress) {
			timeT.text = string.Format ("Time: {0}", Time.time - trackState.lastRaceStart);
		}
		
	}
}
