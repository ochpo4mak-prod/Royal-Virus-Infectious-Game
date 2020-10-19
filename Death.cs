using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	public AudioSource Sound_Click;

void OnMouseUpAsButton () {
		switch (gameObject.name) {
			case "End":
				Sound_Click.Play();
					SceneManager.LoadScene ("Menu");
					break;
		}
	}
}