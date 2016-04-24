using UnityEngine;
using System.Collections;

public class boundryScript : MonoBehaviour {
    private Transform[] waypoints;
    private int currentWaypoint = 0;
	private int lastWaypoint = 0;
	private bool spinO=false;
	private int spinC=0;
	private Vector3 lookPos;
	private Quaternion rotation;
	public AudioSource fI;
	private AudioSource sO;


    public GameObject waypointContainer;

	// Use this for initialization
	void Start () {
		sO = GetComponent<AudioSource> ();
	    // Copy waypoint info from public variable.  The container itself is among the transforms
		// in the container.
        Transform[] potentialWaypoints = waypointContainer.GetComponentsInChildren<Transform>();

		// Create the private waypoint array; it is one smaller than the potential array,
		// since we do not want to include the container itself.
        waypoints = new Transform[potentialWaypoints.Length - 1]; 

		// Loop through the potential array, only copying actual waypoints into the private array.
		for (int i = 0, j = 0; i < potentialWaypoints.Length; i++)
        {
            if (potentialWaypoints[i] != waypointContainer.transform)
            {
                // This is a waypoint rather than the container;
				// add the waypoint to the array.
                waypoints[j++] = potentialWaypoints[i];
            }
        }
	}
	void FixedUpdate(){//implements the spin out animation 
		if (spinO && spinC == 0) {
			lookPos = waypoints[currentWaypoint].position - transform.position;
			lookPos.y = 0;
			rotation = Quaternion.LookRotation(lookPos);
			spinC++;
			sO.Play();
		}
		else if (spinO && spinC < 360) {
			
			 rotation *= Quaternion.Euler(0, 1, 0); // this add a 1 degree Y rotation
			 transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
			spinC++;
		} else {
			spinO = false;
			spinC = 0;
		}
	}

	void Update () {//detects if player is out of bounds and places him back on track
		Vector3 movementVector = NavigateTowardWaypoint();
		if (movementVector.magnitude >= 1600.0f) {
			transform.position = waypoints [lastWaypoint].position;
			transform.rotation = Quaternion.LookRotation(movementVector);
		}
		if (currentWaypoint + 1 == 0)
			fI.Play();
	}

    Vector3 NavigateTowardWaypoint()//updates current waypoint and last waypoint
    {
		// This tells us how close we get to a waypoint before we turn our attention
		// to the next waypoint.
		float neighborhood = 600.0f;

		Vector3 movementVector = waypoints[currentWaypoint].position - transform.position;

		// Are we in the neighborhood of the target waypoint?
		if (movementVector.magnitude <= neighborhood)
        {
			// Yes; focus our attention on the next waypoint in the path.
			lastWaypoint=currentWaypoint;
			currentWaypoint = (currentWaypoint + 1) % waypoints.Length;
        }
		movementVector = waypoints[lastWaypoint].position - transform.position;
        return movementVector;
    }
	void OnTriggerEnter(Collider other){//detects collision with ai
		Vector3 aiVec = waypoints [currentWaypoint].position - other.transform.position;
		Vector3 plVec = waypoints [currentWaypoint].position - transform.position;
		if (other.name.Equals("Cube")&&plVec.magnitude<aiVec.magnitude){
			spinO=true;
		}
	}
}
