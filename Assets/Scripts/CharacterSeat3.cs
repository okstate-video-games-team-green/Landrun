using UnityEngine;
using System.Collections;

public class CharacterSeat3 : MonoBehaviour {

	private GameObject wagon;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



		wagon = GameObject.FindWithTag("womanseat");



		gameObject.transform.position = wagon.transform.position ;
		gameObject.transform.rotation = wagon.transform.rotation ;


	}
}