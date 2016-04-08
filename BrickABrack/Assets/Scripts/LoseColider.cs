using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {

	private LevelManager levelManager;

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D(Collider2D collision){
		levelManager.LoadLevel ("Lose Screen");
	}
}
