using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundgenerator : MonoBehaviour {
	[SerializeField]
	Sprite[] Waifus;

	[SerializeField]
	Sprite[] Backgrounds;

	[SerializeField]
	SpriteRenderer Personagem;
	[SerializeField]
	SpriteRenderer Background;

	// Use this for initialization
	void Start () {
		RandomizeBackground ();

	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("c")){
			RandomizeBackground();
		}
	}

	void RandomizeBackground(){

			int r1 = Random.Range (0, Backgrounds.Length);
			int r2 = Random.Range (0, Waifus.Length);

			Background.sprite = Backgrounds [r1];
			Personagem.sprite = Waifus [r2];
		}
}
