using UnityEngine;
using System.Collections;

public class PuasingController : MonoBehaviour {
	GameObject[] dynamicobjects;
	GameObject pausescreen;
	public bool set = false;
	GameObject player;
	void Start (){
		player = GameObject.FindGameObjectWithTag ("Player");
		dynamicobjects = GameObject.FindGameObjectsWithTag ("Dynamics");
		pausescreen = GameObject.Find ("PauseScreen");
		pausescreen.SetActive (false);
	}
	void Update () {
		if (Input.GetButtonDown ("Pause") == true) {
			pause ();
		}

	}
	public void pause(){
		foreach (GameObject g in dynamicobjects)
			g.SetActive(set);
		player.SetActive(set);
		pausescreen.SetActive (!set);
		if (set == true)
			set = false;
		else
			set = true;
	}
}
