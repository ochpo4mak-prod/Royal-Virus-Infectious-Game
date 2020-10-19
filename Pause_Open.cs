using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Open : MonoBehaviour {

	public GameObject pauseMenu;
	public AudioSource Sound_Click;
	public AudioSource Music;

	void OnMouseUpAsButton()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		Music.Pause();
		Sound_Click.Play();
	}
}