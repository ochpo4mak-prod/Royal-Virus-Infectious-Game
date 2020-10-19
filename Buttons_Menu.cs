using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Buttons_Menu : MonoBehaviour {

	public Sprite najim, nenajim;
	public AudioSource Sound_Click;
	public GameObject Open_menu;

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = najim;
	}

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = nenajim;
	}

	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "Play":
			Sound_Click.Play();
			SceneManager.LoadScene ("Game");
			break;
		case "Help":
			Sound_Click.Play();
			SceneManager.LoadScene ("Help");
			break;
		case "Exit":
			Sound_Click.Play();
			Application.Quit ();
			break;
		case "Rating":
			Sound_Click.Play();
			Social.ShowLeaderboardUI();
			break;
		case  "Settings":
			Sound_Click.Play();
			Open_menu.SetActive(true);
			break;
		case  "bg_settings":
			Sound_Click.Play();
			Open_menu.SetActive(false);
			break;
		case "Rate":
			Sound_Click.Play();
			Application.OpenURL ("https://play.google.com/store/apps/details?id=com.ochpo4makprod.crownvirus");
			break;
		case "AD":
			Sound_Click.Play();
			break;
		}
	}

	public void RemoveAd(){
		Debug.Log("fuck yeah");
		Globals.ad = false;
	}
}