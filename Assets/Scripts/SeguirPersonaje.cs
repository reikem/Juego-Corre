using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {
    //Taller de video Juegos
    //Integrantes Stefy Alvarado / Victoria Rios /Jimmy Meneses
    //2018
    public Transform personaje;
	public float separacion = 6f;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(personaje.position.x+separacion, transform.position.y, transform.position.z);
	}
}
