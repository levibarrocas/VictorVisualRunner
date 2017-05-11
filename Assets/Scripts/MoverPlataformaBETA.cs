using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlataformaBETA : MonoBehaviour {
	// Define a velocidade que a plataforma no eixo X
	[SerializeField]
	[Range(0.1f,5f)]
	float Speed;
	// Acelaracao multipla a speed todo frame
	[SerializeField]
	[Range(0.5f,3)]
	float Aceleracao;
	[SerializeField]
	// Define se a plataforma se meche ou nao
	bool Ativo;
	[SerializeField]
	// Define a direcao negativa ou posita,com true ou false.
	bool Direcao;

	void Start () {
		
	}

	void Update () {
		// Define se ele ou nao,pela Bool Ativo
		if (Ativo) {
			// Define a direcao pelo bool Direcao,true pra esquerda,false pra direita
			if (Direcao) {
				// Ele define um vector 3 chamado position. Ele define position como igual ao position do objeto que o roda o script
				Vector3 position = this.transform.position;
				// Aqui ele adciona a velocidade multiplicado pelo tempo entre frames ao position,o vector 3 que definimos na linha anterior
				position.x += Speed * Time.deltaTime;
				// Aqui ele aplica um aumento na velocidade que todo frame.
				Speed *= Aceleracao;
				// Aqui ele fala que o position original do objeto é definido igual ao que alteramos
				this.transform.position = position;
			} else
				// Se o ultimo if for falso,no caso direcao nao for true,rodar esse code
			{
				// Tudo igual só que ao contrario
				Vector3 position = this.transform.position;
				position.x -= Speed * Time.deltaTime;
				Speed *= Aceleracao;
				this.transform.position = position;
			}
		}
	}
}
// O script meche as plataformas todo frame usando o Update.
// Time.deltatime faz com que nao importa o FPS do jogo,as plataformas sempre se movem a mesma quantidade
