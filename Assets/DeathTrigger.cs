using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {
	[SerializeField]
	GameObject TelaDeGameover;

	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		Destroy (other.gameObject);
		TelaDeGameover.SetActive (true);
	
	}
}
