using UnityEngine;
using System.Collections;
//Taller de video Juegos
//Integrantes Stefy Alvarado / Victoria Rios /Jimmy Meneses
//2018

public class BotonCargarEscena : MonoBehaviour {

	public string nombreEscenaParaCargar = "GameScene";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Camera.main.GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().Play();
		Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);
	}
	
	void CargarNivelJuego(){
		Application.LoadLevel (nombreEscenaParaCargar);
	}
}
