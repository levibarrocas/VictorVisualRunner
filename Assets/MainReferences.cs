using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainReferences : MonoBehaviour {

	public static GameManager GM;
	[SerializeField]
	public static InkIntegration InkIn;
	// Use this for initialization
	void Start () {
		SetReferences ();
	}

	void SetReferences(){
		GM = GetComponent<GameManager> ();

		InkIn = GameObject.Find ("Platform Spawner").GetComponent<InkIntegration> ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
