using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

	// Use this for initialization
	private bool released = false;
	private Vector3 initialPositionOffset;
	private Paddle paddle;

	void Start ()
	{
		paddle = GameObject.FindObjectOfType<Paddle> ();
		initialPositionOffset = transform.position - paddle.transform.position;	
	}

	// Update is called once per frame
	void Update ()
	{
		if (!released) {
			transform.position = paddle.transform.position + initialPositionOffset;
			if (Input.GetMouseButtonDown (0)) {
				released = true;
//				Vector2 direction = new Vector2 (Random.Range(-5,5),Random.Range(8,16));
				Vector2 direction = new Vector2 (1, 6);
				ForceMode2D mode = ForceMode2D.Impulse;

				this.rigidbody2D.AddForce (direction, mode);
			}
		} else {
			if (GameObject.FindObjectsOfType<Brick> ().Length <= 0) {
				LevelManager level = GameObject.FindObjectOfType<LevelManager> ();
				level.LoadNextLevel ();
			}
		}
	}
}
