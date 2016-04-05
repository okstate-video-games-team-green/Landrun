using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UI : MonoBehaviour {
	public Text timeT;
	public Text lapT;
	private float timeF=0f;
	private float lapF = 3f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timeT.text = string.Format ("Time: {0}",timeF);
		timeF+=Time.deltaTime;
		lapT.text = string.Format ("Laps: {0}", lapF);
	}
	public void incLap(){
		lapF -= 1f;
	}
}
