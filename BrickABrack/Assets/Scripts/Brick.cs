using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}

	void OnCollisionEnter2D(Collision2D collision){
		print ("Got A Hit");
		timesHit ++;
		if (timesHit >= maxHits) {
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
