using UnityEngine;
using System.Collections;

//Taller de video Juegos
//Integrantes Stefy Alvarado / Victoria Rios /Jimmy Meneses
//2018
public class ActivarGameOver : MonoBehaviour {

	public GameObject camaraGameOver;
	public AudioClip gameOverClip;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
	}
	
	void PersonajeHaMuerto(Notification notificacion){
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().clip = gameOverClip;
		GetComponent<AudioSource>().loop = false;
		GetComponent<AudioSource>().Play();
		camaraGameOver.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
