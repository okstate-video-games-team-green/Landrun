using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	private GameObject wagon;
	public GameObject start;



	// Use this for initialization
	void Start () {


		wagon = GameObject.FindWithTag("Player");



		wagon.transform.position = start.transform.position ;
		wagon.transform.rotation = start.transform.rotation ;

	}

	// Update is called once per frame
	void Update () {






	}
}
