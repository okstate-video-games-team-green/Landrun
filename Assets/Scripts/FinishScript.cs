using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour {

    public Text raceOver;

	// Use this for initialization
	void Start () {	
        raceOver.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {	
	}
    
    void OnTriggerEnter(Collider empty) {
        raceOver.enabled = true;
    }
}
