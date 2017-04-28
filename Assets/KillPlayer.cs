using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour {

	public string tag = "";
	public static int vidas = 3;
	public GameObject frog;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D theObject){
				if(theObject.tag == "Player"){
					Destroy(theObject.gameObject);

					if(vidas == 3)
					{
						Destroy (GameObject.FindWithTag("vida3"));
						//crear el game object en el position (453, -125, 0)(x,y,z)
						Instantiate(frog, new Vector3(453, -125, 0), Quaternion.Euler(0, 0, 0));
						vidas--;
						Debug.Log(vidas);
					}
					else if(vidas == 2)
					{
						Destroy (GameObject.FindWithTag("vida2"));
						Instantiate(frog,  new Vector3(453, -125, 0), Quaternion.Euler(0, 0, 0));
						vidas--;
					}else if(vidas == 1)
					{
						Destroy (GameObject.FindWithTag("vida1"));
						SceneManager.LoadScene("GameOver");
					}

				}

			if(theObject.tag == "car"){
				Destroy(theObject.gameObject);
			}
			
			if(theObject.tag == "youWin"){
				SceneManager.LoadScene("level2");
			}

	}
}
