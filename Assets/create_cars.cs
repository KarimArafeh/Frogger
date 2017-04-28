using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_cars : MonoBehaviour {

	public GameObject car;
	public float inicio = 0;
	public float repeatCada = 1;
	

	// Use this for initialization
	void Start () {
		InvokeRepeating("CarNext", inicio, repeatCada);
	}
	
	void CarNext () {
		Instantiate(car, transform.position, Quaternion.Euler(0, 0, 90));
	}
}
