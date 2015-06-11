using UnityEngine;
using System.Collections;


public class ai : MonoBehaviour {
	playerController player;

	public float visionDistence = 20f;
	public Transform visionPoint;
	public float vision; 
	public float visionAngle = 30f;
	public float moveSpeed = 2f;
	public float ChaseDistence = 3f;

	// Use this for initialization


	void Start () {
	


	}


	// Update is called once per frame
	void Update () {
	
		}

	void Look() {
		Vector3 deltaToPlayer = player.transform.position - visionPoint.position;
		Vector3 directionToPlayer = deltaToPlayer.normalized;
		float distenceToPlayer = directionToPlayer.magnitude;
		
			float dot = Vector3.Dot (visionPoint.forward, directionToPlayer);

			if (dot < 0)
			{
			return;
			}

			if (distenceToPlayer > visionDistence)
			{
			return;
			}

			float angle = Vector3.Angle (transform.forward, directionToPlayer);

			if (angle > visionAngle)
			{
				return;
			}

			RaycastHit hit;

			if (Physics.Raycast (transform.position, directionToPlayer, out hit, visionDistence))
			{
				if(hit.collider.gameObject == player.gameObject)
				{
					return;
				}
	
				

		}

	}
}
