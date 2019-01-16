using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {
    //Taller de video Juegos
    //Integrantes Stefy Alvarado / Victoria Rios /Jimmy Meneses
    //2018
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
			GameObject personaje = GameObject.Find("Personaje");
			personaje.SetActive(false);
		}else{
			Destroy(other.gameObject);
		}
	}
}
