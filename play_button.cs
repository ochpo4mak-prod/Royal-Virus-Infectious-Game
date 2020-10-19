using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class play_button : MonoBehaviour{

	public AudioSource Sound_Click;
	public AudioSource Music;
	public GameObject Chance1;
	public GameObject Chance2;
	public GameObject Chance3;
	public GameObject Chance4;
	public GameObject pausee;
	public Text Timer;

	//void Update(){
		//Globals.second_time -= Time.deltaTime;
       	//Timer.text = Globals.second_time.ToString("f1") + "";
        //if (Globals.second_time < 0){
        //	SceneManager.LoadScene("Death");
        //	Globals.second_time = 5;
        //}

	//}

	void OnMouseUpAsButton(){
		pausee.SetActive(true);
        Chance1.SetActive(false);
		Chance2.SetActive(false);
		Chance3.SetActive(false);
		Chance4.SetActive(false);
		Time.timeScale = 1f;
		Music.Play();	
		Sound_Click.Play();
	}
}
