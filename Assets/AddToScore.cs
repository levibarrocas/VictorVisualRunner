using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToScore : MonoBehaviour {
	//Define uma variavel chamada GM que guarda um GameManager
	GameManager GM;
	void Start () {
		// Define que o GM é o component GameManager dentro do objeto com a tag  GameController
		GM = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(){
		// Aqui ele usa uma funcao que criamos dentro do gameManager que adciona 2 pontos pra cada frame que o personagem esta na plataforma.
		GM.AddScore (2);
	}
}
// Esse script adciona 2 pontos para cada frame que o jogador esta na plataforma.