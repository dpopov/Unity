using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitStates;
	int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}

	void OnCollisionEnter2D(Collision2D collision){
		timesHit ++;
		if (timesHit >= hitStates.Length + 1) {
			Destroy (gameObject);
		} else {
			this.GetComponent<SpriteRenderer>().sprite = hitStates[timesHit-1]; 
		}
	}
	
}
