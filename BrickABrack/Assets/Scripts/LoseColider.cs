using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {
	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D collision){
		levelManager.LoadLevel ("Win Screen");
	}
}
