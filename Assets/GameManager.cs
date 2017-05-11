using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	// Definicao de duas ints para guardar Vidas e Score,e como sao publicos aparecem no unity
	public int Score;
	public int Vidas;

	// Funcao de adcionar pontuacao(sim ẽ simples assim)
	// ela pede um numero para adciona a pontuacao.
	public void AddScore(int N){
		Score += N;
	}


}
// Esse script na versao final deve guardar e cuidar de gameover,perda de vida, e highscore entre outras coisas.