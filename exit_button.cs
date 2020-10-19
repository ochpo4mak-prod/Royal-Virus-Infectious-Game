using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class exit_button : MonoBehaviour{

	void Start(){
		if (Game.AdvCount % 1 == 0){
			Advertisement.Initialize("3509681", false);
		}
	}

	void OnMouseUpAsButton(){
		SceneManager.LoadScene("Death");
		Time.timeScale = 1f;
		Globals.SecondChanse = true;
		Globals.is_rectangle = false;
		Globals.is_circle = false;
		Globals.is_triangle = false;
		Globals.xtime = 10;
		Globals.x_rectangle = 1f;
		Globals.x_circle = 1f;
		Globals.x_triangle = 1.2f;	
		if (Globals.ad == true){
			Game.AdvCount++;
			if (Game.AdvCount % 2 == 0){
				if (Advertisement.IsReady("3509681")){
					Advertisement.Show();
				}
			}			
		}
	}
}
