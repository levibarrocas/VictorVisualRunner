using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlatformSpawner : MonoBehaviour {
	// Prefab da plataforma
	[SerializeField]
	GameObject PlatformPrefab;
	[SerializeField]
	GameObject JogadorPrefab;
	[SerializeField]
	GameObject SpawnPosition;

	// FOntes de plataformas
	[SerializeField]
	GameObject[] Fontes;
	// Lista de plataformas do jogo
	[SerializeField]
	List<GameObject> Plataformas = new List<GameObject>();
	// Contador de pooling do objeto
	int PoolingCOunter;
	[SerializeField]
	int PoolingLimit;

	public void Reset(){
		for (int i = 0; i < Plataformas.Count; i++) {
			Destroy (Plataformas [i]);
		}

		Plataformas.Clear ();
		GameObject GO = Instantiate (JogadorPrefab,SpawnPosition.transform.position,SpawnPosition.transform.rotation);
	}

	public void SpawnPlatform(string Texto) {
		if (Plataformas.Count < PoolingLimit) {
			GameObject GO;
			GO = Instantiate (PlatformPrefab);
			GO.transform.position = Fontes [3].transform.position;
			if(Plataformas.Count != 0){
			Vector2 posicao = GO.transform.position;
			posicao.x += Texto.Length *0.3f;
			GO.transform.position = posicao;
			}
			Plataformas.Add (GO);
			Text TextoDaPlatforma; 
			TextoDaPlatforma = GO.GetComponentInChildren<Text> ();
			TextoDaPlatforma.text = Texto;
			Vector3 TamanhoHitbox = GO.GetComponent<BoxCollider2D> ().size;
			TamanhoHitbox.x = Texto.Length * 0.0065f;
			GO.GetComponent<BoxCollider2D> ().size = TamanhoHitbox; 
		} else {
			PoolingCOunter++;
			if (PoolingCOunter > PoolingLimit-1) {
				PoolingCOunter = 0;
			}
				
			Plataformas [PoolingCOunter].transform.position = this.transform.position;
			Vector2 posicao = Plataformas [PoolingCOunter].transform.position;
			posicao.x += Texto.Length * 0.3f;
			Plataformas [PoolingCOunter].transform.position = posicao;
			Plataformas [PoolingCOunter].GetComponent<Text> ().text = Texto;
			Vector3 TamanhoHitbox = Plataformas [PoolingCOunter].GetComponent<BoxCollider2D> ().size;
			TamanhoHitbox.x = Texto.Length * 0.0065f;
			Plataformas [PoolingCOunter].GetComponent<BoxCollider2D> ().size = TamanhoHitbox;
			Plataformas [PoolingCOunter].GetComponent<JumpTest> ().IsChoice = false;
		}

	}

	public void SpawnChoicePlatform(string Texto,int ChoiceID) {
		if (Plataformas.Count < PoolingLimit) {
			GameObject GO;
			GO = Instantiate (PlatformPrefab,transform);
			GO.transform.position = Fontes[ChoiceID].transform.position;

			Plataformas.Add (GO);
			Text TextoDaPlatforma; 
			TextoDaPlatforma = GO.GetComponentInChildren<Text> ();
			TextoDaPlatforma.text = Texto;
			Vector3 TamanhoHitbox = GO.GetComponent<BoxCollider2D> ().size;
			TamanhoHitbox.x = Texto.Length * 0.0065f;
			GO.GetComponent<BoxCollider2D> ().size = TamanhoHitbox; 
			GO.GetComponent<JumpTest> ().IsChoice = true;
			GO.GetComponent<JumpTest> ().ChoiceSlot = ChoiceID;
		} else {
			PoolingCOunter++;
			if (PoolingCOunter > PoolingLimit -1) {
				PoolingCOunter = 0;
			}

			Plataformas [PoolingCOunter].transform.position = Fontes[ChoiceID].transform.position;

			Plataformas [PoolingCOunter].GetComponent<Text> ().text = Texto;
			Vector3 TamanhoHitbox = Plataformas [PoolingCOunter].GetComponent<BoxCollider2D> ().size;
			TamanhoHitbox.x = Texto.Length * 0.0065f;
			Plataformas [PoolingCOunter].GetComponent<BoxCollider2D> ().size = TamanhoHitbox;
			Plataformas [PoolingCOunter].GetComponent<JumpTest> ().IsChoice = true;
			Plataformas [PoolingCOunter].GetComponent<JumpTest> ().ChoiceSlot = ChoiceID;
		}
	}

}
