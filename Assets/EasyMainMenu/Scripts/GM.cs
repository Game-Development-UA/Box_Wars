using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public static float vertVel = 0;
	public static int coinTotal = 0;
	public static float timeTotal = 0;
	public float waittoload = 0;

	public static float zVelAdj = 1;

	public static string lvlCompStatus = "";

	public Transform bbNoPit;
	public Transform bbPitRight;
	public Transform bbPitLeft;
	public Transform bbPitMid;
	public Transform ExitObj;
	public Transform coinObj;
	public Transform obstObj;
	public Transform powerupObj;
	public int randNum;

	public float zScenePos = 0;


	void Start () {
		Instantiate(ExitObj, new Vector3(0, 2.8f, 121 ), ExitObj.rotation);
		while (zScenePos <= 16) {
			Instantiate(bbNoPit, new Vector3(0, 0f, zScenePos ), bbNoPit.rotation);
			zScenePos +=4;
			//ends at 18
		}
		zScenePos = 26; // skips ramp
	}
	
	// Update is called once per frame
	void Update () {

		if (zScenePos < 120) {
			//post ramp blocks
			while (zScenePos < 29) {
			Instantiate(bbNoPit, new Vector3(0, 2.3f, zScenePos ), bbNoPit.rotation);
			zScenePos +=4;
			}

			//instatiate random items/obstacles
			randNum = Random.Range (0, 25);
			//coin left
			if (randNum < 2) {
				Instantiate(coinObj, new Vector3(-1, 3.5f, zScenePos), coinObj.rotation);
			}
			//coin mid
			if (randNum >= 2 && randNum < 4 ) {
				Instantiate(coinObj, new Vector3(0, 3.5f, zScenePos), coinObj.rotation);
			}
			//coin right
			if (randNum >= 4 && randNum < 6 ) {
				Instantiate(coinObj, new Vector3(1, 3.5f, zScenePos), coinObj.rotation);
			}
			//obst right
			if (randNum == 6) {
				Instantiate(obstObj, new Vector3(1, 3.5f, zScenePos), obstObj.rotation);
			}
			//obst mid
			if (randNum == 7) {
				Instantiate(obstObj, new Vector3(0, 3.5f, zScenePos), obstObj.rotation);
			}
			//obst left
			if (randNum == 8) {
				Instantiate(obstObj, new Vector3(-1, 3.5f, zScenePos), obstObj.rotation);
			}
			//obst outsides
			if (randNum == 9) {
				Instantiate(obstObj, new Vector3(-1, 3.5f, zScenePos), obstObj.rotation);
				Instantiate(obstObj, new Vector3(1, 3.5f, zScenePos), obstObj.rotation);
			}
			//obst midright
			if (randNum == 10) {
				Instantiate(obstObj, new Vector3(0, 3.5f, zScenePos), obstObj.rotation);
				Instantiate(obstObj, new Vector3(1, 3.5f, zScenePos), obstObj.rotation);
			}
			//obst midleft
			if (randNum == 11) {
				Instantiate(obstObj, new Vector3(0, 3.5f, zScenePos), obstObj.rotation);
				Instantiate(obstObj, new Vector3(-1, 3.5f, zScenePos), obstObj.rotation);
			}
			//powerup mid
			if (randNum == 12) {
				Instantiate(powerupObj, new Vector3(0, 3.5f, zScenePos), powerupObj.rotation);
			}
			//powerup left
			if (randNum == 13) {
				Instantiate(powerupObj, new Vector3(-1, 3.5f, zScenePos), powerupObj.rotation);
			}
			//powerup
			if (randNum == 14) {
				Instantiate(powerupObj, new Vector3(1, 3.5f, zScenePos), powerupObj.rotation);
			}
/*
			//pit right
			if (randNum == 15) {
				Instantiate(bbPitRight, new Vector3(0, 3.5f, zScenePos), bbPitRight.rotation);
			}
			//pit mid
			if (randNum == 16) {
				Instantiate(bbPitMid, new Vector3(0, 3.5f, zScenePos), bbPitMid.rotation);
			}
			//pit left
			if (randNum == 17) {
				Instantiate(bbPitLeft, new Vector3(0, 3.5f, zScenePos), bbPitLeft.rotation);
			}
			//pit outsides
			if (randNum == 18) {
				Instantiate(bbPitLeft, new Vector3(0, 3.5f, zScenePos), bbPitLeft.rotation);
				Instantiate(bbPitRight, new Vector3(0, 3.5f, zScenePos), bbPitRight.rotation);
			}
			//pit midright
			if (randNum == 19) {
				Instantiate(bbPitMid, new Vector3(0, 3.5f, zScenePos), bbPitMid.rotation);
				Instantiate(bbPitRight, new Vector3(0, 3.5f, zScenePos), bbPitRight.rotation);
			}
			//pit midleft
			if (randNum == 20) {
				Instantiate(bbPitMid, new Vector3(0, 3.5f, zScenePos), bbPitMid.rotation);
				Instantiate(bbPitLeft, new Vector3(0, 3.5f, zScenePos), bbPitLeft.rotation);
			}
*/
			//else normal tiles
			Instantiate(bbNoPit, new Vector3(0, 2.3f, zScenePos ), bbNoPit.rotation);
			zScenePos += 4;
		}


		timeTotal += Time.deltaTime;

		if (lvlCompStatus == "Fail") {
			waittoload += Time.deltaTime;

		}

		if (waittoload > 1) {
			SceneManager.LoadScene("LevelComplete");
		}
	}
}
