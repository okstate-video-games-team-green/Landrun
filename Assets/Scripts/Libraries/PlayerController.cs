using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour {
	
    [SerializeField]
	private float speed = 5.0f;
	private PlayerMovement movement;
	[SerializeField]
	private float rotationSpeed = 5.0f;

    private float zMov;
    private Vector3 velocity;
    private Vector3 movVert;
    //private Vector3 surfaceNormal;
    //private Vector3 heading;
    
    // Use this for initialization
	void Start () {
		movement = GetComponent<PlayerMovement> ();
    }
	
	// Update is called once per frame
	void Update () {
        
//***********START**********    
/*      Ray toGround = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        Physics.Raycast(toGround, out hit);

// Reference - http://answers.unity3d.com/questions/10323/calculating-a-movement-direction-that-is-a-tangent.html        
// Reference - http://docs.unity3d.com/540/Documentation/Manual/DirectionDistanceFromOneObjectToAnother.html        
        
        surfaceNormal = hit.normal;
        heading = hit.collider.gameObject.GetComponent<Transform>().position - GetComponent<Transform>().position;
        float distance = heading.magnitude;
        Vector3 myDirection = heading/distance;
        
        
        //print(Physics.Raycast(toGround, out hit));
        //print(hit.collider.gameObject.tag);
        //print(hit.normal);
        //print(hit.distance);
        
        if (hit.distance < 5)
        {
            zMov = Input.GetAxis("Vertical");
            print(hit.distance);
            //print(zMov);
        }*/
//**********END**********
        
        //float xMov = Input.GetAxis ("Horizontal");
		zMov = Input.GetAxis ("Vertical");
		movVert = transform.forward * zMov;
		velocity = (movVert).normalized * speed;
		movement.Move (-velocity);
		float yRot = Input.GetAxis ("Horizontal");
		Vector3 rotation=new Vector3(0,yRot,0)*rotationSpeed;
		movement.Rotate(rotation);   

       
	}
	
/*    void FixedUpdate() {
        Vector3 orthogVector = Vector3.Cross(surfaceNormal, myDirection);
        Vector3 myDirection = Vector3.Cross(orthogVector, surfaceNormal);
    }*/
    
    /*void OnBecameInvisible() {
		Destroy (this.gameObject);
		WinG ();
	}
	public void WinG(){
		SceneManager.LoadScene ("S2");
	}*/
}
