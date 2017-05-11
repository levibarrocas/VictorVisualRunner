using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Faz o unity se preparar para ler codes de Interface,porque se nao os comandos vao ser ignorados.
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour {
	//Define um espaço vazio pra guardar um Texto
	[SerializeField]
	// SerializeField permite editar essa variavel pelo editor envez de pelo script
	Text ScoreDisplay;

	// Define um espaço vazio para guardar um GM
	GameManager GM;

	// Use this for initialization
	void Start () {
		// Define que GM é o GameManager dentro desse objeto
		GM = GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		//Todo frame ele altera o ScoreDisplay pra ser =
		// Score: + a pontuacao
		// ToString() converte o numero puro INT para String
		ScoreDisplay.text = "Score: " + GM.Score.ToString();
	}
}
// Esse script altera a scoreboard do jogo todo frame.No futuro esse script deveria guardar tudo de interface do jogo,como vidas,especiais e etc