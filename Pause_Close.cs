using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Close : MonoBehaviour {

	public GameObject pauseMenu;
	public AudioSource Sound_Click;
	public AudioSource Music;

	void OnMouseDown()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		Music.Play();
		Sound_Click.Play();
	}
}