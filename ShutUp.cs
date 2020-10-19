using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShutUp : MonoBehaviour{

	public AudioSource Sound_Click;
	public Sprite enableSprite;
    public Sprite disableSprite;
	
    void Start(){
    	Globals.sound = PlayerPrefs.GetInt("Sound") == 1 ? true : false;
    }

    void Update(){
    	if (Globals.sound == false){
    		AudioListener.volume = 0f;
    		GetComponent <SpriteRenderer> ().sprite = disableSprite;
    	}
    	else{
    		AudioListener.volume = 1f;
    		GetComponent <SpriteRenderer> ().sprite = enableSprite;
    	}
    	PlayerPrefs.SetInt("Sound", Globals.sound ? 1 : 0);
    }
	void OnMouseUpAsButton(){
		switch (gameObject.name){
		case "Sound_on":
			if (Globals.sound == true){
				Sound_Click.Play();
				Globals.sound = false;
			}
			else{
				Globals.sound = true;
				Sound_Click.Play();
			}
			break;
		}
    }
}
