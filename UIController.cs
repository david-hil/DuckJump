using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	int coinnumber;
	public int collectedcoins = 0;
	string message;
	void Start () {
		GameObject[] coins = GameObject.FindGameObjectsWithTag ("Coin");
		foreach (GameObject x in coins)
			++coinnumber;
	}
	void Update () {
		message = collectedcoins + "/" + coinnumber;
		this.gameObject.GetComponentInChildren<Text> ().text = message;
		GameObject.Find ("Level").GetComponent<Text>().text = "Level " + (GameObject.Find("Coin").GetComponent<CoinController>().levelnumber + 1);
	}
}
