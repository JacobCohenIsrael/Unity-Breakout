using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter (Collider col)
	{
		Debug.Log("Ball Hit The Water");
		GameManager.instance.LoseLife();
	}
}