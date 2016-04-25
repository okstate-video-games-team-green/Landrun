using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {
	private Vector3 velocity=Vector3.zero;
	private Rigidbody rigidBody;
	private Vector3 rotation = Vector3.zero;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
    {}

	public void Move(Vector3 _velocity){
		velocity = _velocity;
	}

	public void Rotate(Vector3 _rotation){
		rotation = _rotation;
	}

	void FixedUpdate()
    {}
}
