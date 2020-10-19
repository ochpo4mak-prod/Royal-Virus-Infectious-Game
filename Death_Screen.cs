using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death_Screen : MonoBehaviour{
    public Text Time;
    public Text Best;

    void Update(){
		Time.text = Globals.time.ToString("f1") + "";
        Best.text = Globals.hscore.ToString("f1") + "";
    }
}