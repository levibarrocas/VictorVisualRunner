using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
	//Muda a força do pulo
	public float ForcaPulo;
	// Criando uma variavel que segura um Rigidbody2D
	Rigidbody2D RB2;

	// Bool que decide se o personagem pode ou nao pular. TRUE = PODE PULAR
	public bool Pular;

	void Start(){
		// Definindo que o rigidbody dentro do objeto que o script esta dentro ẽ o rigidbody dentro do script
		RB2 = GetComponent<Rigidbody2D> ();
	}


	void Update (){
		//Decide se ele pode pular ou nao. Para quando ele estiver no ar ele nao pode pular denovo
		if (Pular) {
			// Define que se a Tecla "space" descer o personagem pula
			if (Input.GetKeyDown ("space")) {
				// RB2.Addforce Adciona força no rigidbody2D preso a variavel RB2
				// Vector2.UP é a direcao da força
				// Multiplicada pela do forca do pulo
				// Multiplicada pelo tempo entre cada frame.
				RB2.AddForce (Vector2.up * ForcaPulo * Time.deltaTime);
			}
		}



	}
}
