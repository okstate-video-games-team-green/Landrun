using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {
	private Vector3 velocity=Vector3.zero;
	private Rigidbody rigidBody;
	private Vector3 rotation = Vector3.zero;

	public TrackState trackState;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
<<<<<<< HEAD
    {}
=======
    {
		
	}
>>>>>>> d00318f0e5fc375d4aa5b994b18bdc7558e66cfa

	public void Move(Vector3 _velocity){
		if (trackState.inProgress) {
			velocity = _velocity;
		} else {
			velocity = Vector3.zero;
		}
	}

	public void Rotate(Vector3 _rotation){
		if (trackState.inProgress) {
			rotation = _rotation;
		} else {
			rotation = Vector3.zero;
		}
	}

<<<<<<< HEAD
	void FixedUpdate()
    {}
=======
	void FixedUpdate(){
		rigidBody.MovePosition (rigidBody.position + velocity * Time.fixedDeltaTime);
		rigidBody.MoveRotation (rigidBody.rotation * Quaternion.Euler (rotation));
	}
>>>>>>> d00318f0e5fc375d4aa5b994b18bdc7558e66cfa
}
