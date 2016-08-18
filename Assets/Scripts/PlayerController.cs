using UnityEngine;
using System;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private float lerpTime;
	private float currentLerpTime;
	private float perc = 1;

	Vector3 startPos;
	Vector3 endPos;

	public bool firstInput;
	public bool isJumping;
	public Vector3 dir;
	public float moveLength = 1;

	void Update()
	{
		startPos = gameObject.transform.position;
		dir = Vector3.zero;

		if (Input.GetKey("right"))
		{
			dir.x += 1;
		}
		if (Input.GetKey("left"))
		{
			dir.x -= 1;
		}
		if (Input.GetKey("up"))
		{
			dir.z += 1;
		}
		if (Input.GetKey("down"))
		{
			dir.z -= 1;
		}

		if (dir.magnitude > 0.0 && perc == 1)
		{
			lerpTime = 1;
			currentLerpTime = 0;
			firstInput = true;
			isJumping = true;
		}

		if (gameObject.transform.position == endPos) {
			endPos = transform.position+dir*moveLength;
		}

		if (firstInput == true)
		{
			currentLerpTime += Time.deltaTime * 5;
			perc = currentLerpTime / lerpTime;
			gameObject.transform.position = Vector3.Lerp(startPos, endPos, perc);
			if (perc > 0.8)
			{
				perc = 1;
			}
			if (Mathf.Round(perc) == 1)
			{
				isJumping = false;
			}
		}
	}
}