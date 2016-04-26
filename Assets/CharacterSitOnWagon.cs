using UnityEngine;
using System.Collections;

public class CharacterSitOnWagon : MonoBehaviour {


	public GameObject wagon;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		gameObject.transform.position = wagon.transform.position;

	}
}
