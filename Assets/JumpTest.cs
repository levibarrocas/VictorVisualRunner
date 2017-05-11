using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTest : MonoBehaviour {
	// Define que o script vai guardar um Craracter Controller
	CharacterController CC;

	public int ChoiceSlot;
	public bool IsChoice;

	// Roda quando o jogo inicia
	void Start () {
		// Ele define oque o CC vai ser.
		// Ele procura um gameobject que tenham a tag player
		// Ele pega o componente character controller do gameobject com a tag player
		CC = GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterController> ();
	}
	//Quando o jogador sai do trigger ele desativa o boolean,que em si faz o jogador nao pode pular
	void OnCollisionExit2D(){
		CC.Pular = false;
	}
	// Quando o jogador entra o trigger ele ativa o boolean,e permite o jogador pular
	void OnCollisionEnter2D(){
		CC.Pular = true;
		if (IsChoice) {
			MainReferences.InkIn.PressionarButaoDeOpcao (ChoiceSlot);
		} else {

			MainReferences.InkIn.ContinuarPressionado = true;
		}

	}
}

// RESUMO : ESSE SCRIPT CONTROLA SE O JOGADOR PODE PULAR OU NAO,ELE RODA NOS TRIGGERS DAS PLATAFORMAS
