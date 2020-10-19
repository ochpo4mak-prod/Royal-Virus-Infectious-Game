using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ad_button : MonoBehaviour{

	public GameObject Timer;

	void OnMouseUpAsButton(){
		Globals.ad_but = true;
		Globals.second_now = true;
		//Timer.SetActive(false);
	}
}
