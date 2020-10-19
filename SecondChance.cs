using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class SecondChance : MonoBehaviour, IUnityAdsListener{

	public AudioSource Sound_Click;
	public AudioSource Music;
	public GameObject Chance1;
	public GameObject Chance2;
	public GameObject Chance3;
	public GameObject Chance4;
	public GameObject pausee;
	public Text Timer;
    public string myPlacementId = "rewardedVideo";

    void Start(){
        if (Globals.second_now == true){
        	Advertisement.AddListener(this);
        	Advertisement.Initialize("3509681", false);
        }
    }

    void Update(){
        if (Globals.second_now == true){
        	pausee.SetActive(false);
        	Chance1.SetActive(true);
			Chance2.SetActive(true);
			Chance3.SetActive(true);
			Time.timeScale = 0f;
			Music.Pause();				
			//Sound_Click.Play();
			Globals.second_now = false;
			Globals.SecondChanse = false;
			if (Globals.ad_but == true){
				if (Advertisement.IsReady("3509681")){
					Advertisement.Show("rewardedVideo");
					Globals.ads_all = true;
					Globals.ad_but = false;	
					Chance3.SetActive(false);
					Chance4.SetActive(true);
				}		
			}

			//if (Globals.ads_all == true){
			//	print("all right");
			//}

			//Globals.second_time -= Time.deltaTime;
       		//Timer.text = Globals.second_time.ToString("f1") + "";
        	//if (Globals.second_time < 0){
        	//	SceneManager.LoadScene("Death");
        	//	Globals.second_time = 5;
        	//}
        }
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult){
        if (showResult == ShowResult.Finished){
        	print("finish");
            Chance4.SetActive(true);
        }
        else if (showResult == ShowResult.Skipped){
            SceneManager.LoadScene("Death");
        }
        else if (showResult == ShowResult.Failed){
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
    public void OnUnityAdsReady (string placementId) {
        // If the ready Placement is rewarded, show the ad:
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
        Debug.LogWarning("The ad did not finish due to an error.");
    }

    public void OnUnityAdsDidStart (string placementId) {
        // Optional actions to take when the end-users triggers an ad.
        print("start");
        Chance4.SetActive(true);
    } 
}
