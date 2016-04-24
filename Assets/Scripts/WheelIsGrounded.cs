using UnityEngine;
using System.Collections;

public class WheelIsGrounded : MonoBehaviour {

	private WheelCollider wheelCollider;
    
    // Use this for initialization
	void Start () {
        wheelCollider = GetComponent<WheelCollider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        WheelHit hit;
        wheelCollider.GetGroundHit (out hit);
	}
    
    void OnTriggerEnter(Collider col)
    {
        WheelHit hit;
        wheelCollider = GetComponent<WheelCollider>();
        print(hit.collider.tag);
    }
    
}
