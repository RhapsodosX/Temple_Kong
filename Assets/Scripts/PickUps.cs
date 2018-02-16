using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour {

	public CircleCollider2D circleCollider;
	public BoxCollider2D boxCollider;
	private int score;

	void OnTriggerEnter2D(Collider2D collider){
		Destroy (gameObject);
		score = PlayerPrefs.GetInt ("PlayerScore");
		score += 800;
		PlayerPrefs.SetInt ("PlayerScore", score);
	}
}
