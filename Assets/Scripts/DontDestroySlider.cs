using UnityEngine;
using System.Collections;

public class DontDestroySlider : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
