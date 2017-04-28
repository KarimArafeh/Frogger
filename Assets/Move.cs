using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed = 5.0f;

	void FixedUpdate(){
			// Get input from key WSAD, Gampads, ....
			float h = Input.GetAxisRaw("Horizontal");
			float v = Input.GetAxisRaw("Vertical");

			// set the rigidbody's velocity
			Vector2 dir = new Vector2(h, v);
			GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

			//animacion a la hora de mover pa arriba
			GetComponent<Animator>().SetBool("jumbing", (v > 0));
			//animacion a la hora de mover pa abajo
			GetComponent<Animator>().SetBool("JumpDown", (v < 0));
			//animacion a la hora de mover a la drecha
			GetComponent<Animator>().SetBool("RightJump", (h > 0));
			//animacion a la hora de mover a la esquera
			GetComponent<Animator>().SetBool("LeftJump", (h < 0));
	}
	
	
}
