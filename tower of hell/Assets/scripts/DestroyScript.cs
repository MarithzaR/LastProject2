using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.position);
	}
	void OnCollisionEnter2D(Collision2D collision){
		//Destroy (this.gameObject);
		Debug.Log (collision.gameObject.name);
		if (collision.gameObject.name != "Player") {
			Destroy (this.gameObject);
		}
	}
}
