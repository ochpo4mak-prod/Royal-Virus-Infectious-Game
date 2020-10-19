using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Move_Logo : MonoBehaviour{

	public float speed;
	private Vector3 target = new Vector3 (0, -0.2f, 0);
	private const string leaderboard = "CgkI5v-bw7AXEAIQAQ";

	void Start(){
		PlayGamesPlatform.Activate();
		Social.localUser.Authenticate((bool success) => {

		});
	}


	void Update() {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
		if (transform.position == target && target.y != 0.2f)
			target.y = 0.2f;
		else if (transform.position == target && target.y == 0.2f)
			target.y = -0.2f;

        long forscore = Convert.ToInt64(Globals.hscore * 10);
        Social.ReportScore(forscore, leaderboard, (bool success) => {

        });			
	}
}