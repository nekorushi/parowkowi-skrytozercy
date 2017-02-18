using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDestroy : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -25) {
			Destroy(gameObject);
		}		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log(other.gameObject.tag);

		if (other.gameObject.tag == "Player") {
			Destroy(gameObject);
			GameManager.gm.EndGame();
		}
        
    }
}
