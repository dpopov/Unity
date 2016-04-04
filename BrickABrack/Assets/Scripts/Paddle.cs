using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	void Update () {
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		Vector3 position = transform.position;
		position.x = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
		transform.position = position;
	}
}
