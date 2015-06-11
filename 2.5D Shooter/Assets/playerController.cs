using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]

public class playerController : MonoBehaviour {
	public float turnSpeed = 300;
	public float inputTurn;
	public float movementForward; 
	public float movementSide;
	public float movementSpeed = 5;

	CharacterController charecterController; 

	void Awake () {

				charecterController = GetComponent<CharacterController> ();
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		inputTurn = Input.GetAxis ("Mouse X");

		movementForward = Input.GetAxis ("Horizontal");
		movementSide = Input.GetAxis ("Vertical");
			
	}
	void FixedUpdate()
	{
		transform.Rotate (Vector3.up, inputTurn * turnSpeed * Time.fixedDeltaTime);

			Vector3 delta = Vector3.zero; 

			delta += transform.forward * movementForward * movementSpeed * Time.fixedDeltaTime;
			delta += transform.right * movementSide * movementSpeed * Time.fixedDeltaTime;

			charecterController.Move (delta);

			//charecterController.Move (
		}
}
