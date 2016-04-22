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

	// Use this for initialization
	void Start () {
		movement = GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		//float xMov = Input.GetAxis ("Horizontal");
		float zMov = Input.GetAxis ("Vertical");
		//Vector3 movHoriz = transform.right * xMov;
		Vector3 movVert = transform.forward * zMov;
		Vector3 velocity = (/*movHoriz + */movVert).normalized * speed;
		movement.Move (-velocity);
		//float yRot = Input.GetAxis ("Mouse X");
		float yRot = Input.GetAxis ("Horizontal");
		Vector3 rotation=new Vector3(0,yRot,0)*rotationSpeed;
		movement.Rotate(rotation);
	}
	/*void OnBecameInvisible() {
		Destroy (this.gameObject);
		WinG ();
	}
	public void WinG(){
		SceneManager.LoadScene ("S2");
	}*/
}
