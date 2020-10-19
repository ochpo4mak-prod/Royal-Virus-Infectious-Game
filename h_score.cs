using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class h_score : MonoBehaviour
{
	public Text H_score;

	void Update(){
		Globals.hscore = PlayerPrefs.GetFloat("HighScore");
		H_score.text = Globals.hscore.ToString("f1") + "";
	}
}
