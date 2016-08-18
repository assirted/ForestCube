using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
	Animator anim;
	public GameObject player;

	private PlayerController controller;

	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	void Awake ()
	{
		controller = player.GetComponent<PlayerController> ();
	}
	
	void Update ()
	{
		if (controller.isJumping && controller.dir.magnitude > 0.0) {
			anim.SetBool ("Bounce", true);

			float yawAngle = 0.0f;

			if (controller.dir.x == -1) {
				yawAngle = -90f;
			}
			if (controller.dir.x == 1) {
				yawAngle = 90f;
			}
			if (controller.dir.z == -1) {
				yawAngle = 180.0f;
			}
			if (controller.dir.z == 1) {
				yawAngle = 0.0f;
			}

			gameObject.transform.rotation = Quaternion.Euler (0, yawAngle, 0);
		} else {
			anim.SetBool ("Bounce", false);
		}
	}
}
