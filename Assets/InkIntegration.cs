using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class InkIntegration : MonoBehaviour {

	public TextAsset inkAsset;

	public Story InkStory;

	public PlatformSpawner TextVisualizer;

	bool StoryStarted;

	public bool ContinuarPressionado = false;

	public Text[] TextosDeResposta;

	public GameObject[] BotoesDeResposta;

	public string NomeImagem;


	public float Cooldown;



	void Awake () {
		InkStory = new Story (inkAsset.text);
	}

	// Use this for initialization
	void Start () {

	}

	public void Reset(){
		InkStory.ResetState ();
		TextVisualizer.Reset ();
	}

	// Update is called once per frame
	void Update () {
		Cooldown += Time.deltaTime;

		if (!StoryStarted) {
			if (InkStory.canContinue) {
				TextVisualizer.SpawnPlatform (InkStory.Continue ());
				SpawnChoices ();
				StoryStarted = true;
			}
		}
		if (InkStory.canContinue) {
			if (ContinuarPressionado) {
				if (Cooldown > 2) {
					TextVisualizer.SpawnPlatform (InkStory.Continue ());
					ContinuarPressionado = false;
					SpawnChoices ();
					Cooldown = 0;
				}
			}
		}
	}


public void SpawnChoices(){
	if( InkStory.currentChoices.Count > 0 ) 
	{
		for (int i = 0; i < InkStory.currentChoices.Count; ++i) {
			Choice choice = InkStory.currentChoices [i];

			TextVisualizer.SpawnChoicePlatform (InkStory.currentChoices [i].text,i);
			
			Debug.Log("Choice " + (i + 1) + ". " + choice.text);

		}
	}
}

	public void PressionarButaoDeOpcao(int ChoiceOption){
		InkStory.ChooseChoiceIndex(ChoiceOption);
		ContinuarPressionado = true;
	}
	public void ContinuarTexto(){
		ContinuarPressionado = true;

	}

}
