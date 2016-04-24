using UnityEngine;
using System.Collections;

public class StartAI : MonoBehaviour {

	public TrackState state;
	private SplineController splineController;
	public Rigidbody rigidBody;

	private bool startedAI = false;

	// Use this for initialization
	void Start () {
		this.splineController = GetComponent<SplineController> ();
		this.rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!startedAI && state.inProgress) {
			rigidBody.constraints = RigidbodyConstraints.None;
			splineController.FollowSpline ();
			startedAI = true;
		}
	}
}
