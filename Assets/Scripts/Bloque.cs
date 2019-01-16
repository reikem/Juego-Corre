using UnityEngine;
using System.Collections;
//Taller de video Juegos
//Integrantes Stefy Alvarado / Victoria Rios /Jimmy Meneses
//2018

public class Bloque : MonoBehaviour {

	private bool haColisionadoConElJugador = false;
	public int puntosGanados = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(!haColisionadoConElJugador && collision.gameObject.tag == "Player"){
			GameObject obj = collision.contacts[0].collider.gameObject;
			if(obj.name == "PataInferiorDerechaB" || obj.name == "PataInferiorIzquierdaB"){
				haColisionadoConElJugador = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			}
		}
	}
}
