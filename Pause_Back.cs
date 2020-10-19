using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Back : MonoBehaviour{

	public GameObject pauseMenu;
	public AudioSource Sound_Click;
	public AudioSource Music;
	
    void Update(){
        if (Input.GetKey(KeyCode.Escape)){
			pauseMenu.SetActive(true);
			Time.timeScale = 0f;
			Music.Pause();
			Sound_Click.Play();
        }
    }
}
