using UnityEngine;
using System.Collections;

public class Despawn2D : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {

			other.gameObject.GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("SpawnZone").GetComponent<Transform>().position;

			//Application.LoadLevel (Application.loadedLevelName);
		} else {
			Destroy (other.gameObject);
		}
	}
}
