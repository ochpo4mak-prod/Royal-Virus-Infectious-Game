using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class Game : MonoBehaviour{

	public static bool multiTouchDisabled;

	//public GameObject Circle;
	//public Vector2 mousePos;
	bool MouseDown = false;
	public static int AdvCount = 0;
	public AudioSource Death;
	private Rigidbody2D rb;
	private Vector3 dir;

	void Start(){
		Globals.time = 0;

		int n = UnityEngine.Random.Range(1, 4);

		if(n == 1){
			Globals.is_triangle = true;			
		}
		if(n == 2){
			Globals.is_circle = true;
		}
		if(n == 3){
			Globals.is_rectangle = true;
		}
		if (AdvCount % 1 == 0){
			Advertisement.Initialize("3509681", false);
		}
		rb = GetComponent<Rigidbody2D>();
	}	



	void OnMouseDown(){
		MouseDown = true;
	}

	void OnMouseUp(){
		MouseDown = false;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Finish"){
			Death.Play();
			if (Globals.SecondChanse == false){
				SceneManager.LoadScene("Death");
				Globals.SecondChanse = true;
				Globals.is_rectangle = false;
				Globals.is_circle = false;
				Globals.is_triangle = false;
				Globals.xtime = 10;
				Globals.x_rectangle = 1f;
				Globals.x_circle = 1f;
				Globals.x_triangle = 1.2f;	
				AdvCount++;
				if (AdvCount % 2 == 0){
					if (Advertisement.IsReady("3509681")){
						Advertisement.Show();
					}
				}	
			}
			else{
				Globals.second_now = true;
			}
		}
	}

	void Update(){
		Vector3 Cursor = Input.mousePosition;
		Cursor = Camera.main.ScreenToWorldPoint(Cursor);
		Cursor.z = 0;

		if (Input.touchCount > 0 && Input.touchCount < 2){		
			Touch touch = Input.GetTouch(0);
			dir = (Cursor - transform.position);
			rb.velocity = new Vector2(dir.x, dir.y) * 10f;

			if (touch.phase == TouchPhase.Ended){
				rb.velocity = Vector2.zero;
			}
			//this.transform.position = Cursor;
		}

		Globals.xtime -= Time.deltaTime;
		if (Globals.xtime < 0){
			Globals.x =	Globals.time % 10 * 0.015f;
			Globals.x_rectangle += Globals.x;
			Globals.x_circle += Globals.x;
			Globals.x_triangle += Globals.x;	
			Globals.xtime = 10;
		}
 	}
}
