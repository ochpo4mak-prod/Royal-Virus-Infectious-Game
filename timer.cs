using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour{

	public Text Timer;

    void Update(){
        Globals.time += Time.deltaTime;
        Timer.text = Globals.time.ToString("f1") + "";
        if (Globals.time > Globals.hscore){
        	Globals.hscore = Globals.time;
        	PlayerPrefs.SetFloat("HighScore", Globals.hscore);
        }
	}
}