using UnityEngine;
using System.Collections;

public class WaterDie : MonoBehaviour {

	public int PlayerHealth = 100;
	int damage = 100;

	void Start () {
		print(PlayerHealth);
	}

	void OnCollisionEnter(Collision _Collision)
	{
		if(_Collision.gameObject.tag == "Water")
		{
			PlayerHealth -= damage;
			if(PlayerHealth>=0)
			{
				//Application.LoadLevel(Application.loadedLevel);
				print("kalah bego");
			}
			print("tulul" + PlayerHealth);
		}
	}
}
