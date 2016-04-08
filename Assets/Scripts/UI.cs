using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UI : MonoBehaviour {
	public Text timeT;
	private float timeF=0f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timeT.text = string.Format ("Time: {0}",timeF);
		timeF+=Time.deltaTime;
	}
}
