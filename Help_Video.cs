using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Help_Video : MonoBehaviour
{
    void Update(){
        Globals.htime -= Time.deltaTime;
        if (Globals.htime < 0){
        	SceneManager.LoadScene ("Menu");
        	Globals.htime = 19;
        }
    }
}