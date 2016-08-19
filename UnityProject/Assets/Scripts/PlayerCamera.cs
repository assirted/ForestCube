using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public GameObject MainPlayer;
	Vector3 shouldPos;

	void Update ()
	{
		shouldPos = Vector3.Lerp(gameObject.transform.position, MainPlayer.transform.position, Time.deltaTime);
		gameObject.transform.position = new Vector3(shouldPos.x, 1, shouldPos.z);
	}
}
