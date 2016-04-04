using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	bool released = false;
	Vector3 initialPositionOffset;
	public Paddle paddle;

	void Start () {
		initialPositionOffset = transform.position-paddle.transform.position;	
	}

	// Update is called once per frame
	void Update () {
		if (!released) {
			transform.position = paddle.transform.position + initialPositionOffset;
			if (Input.GetMouseButtonDown (0)) {
				released = true;
//				Vector2 direction = new Vector2 (Random.Range(-5,5),Random.Range(4,8));
				Vector2 direction = new Vector2 (0,6);
				ForceMode2D mode = ForceMode2D.Impulse;

				this.rigidbody2D.AddForce(direction,mode);
			}
		}
	}
}
