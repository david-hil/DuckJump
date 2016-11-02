using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour {
	public int levelnumber = 0;
	bool reversed = false;
	bool forward = true;
	void OnCollisionEnter2D(Collision2D col){
		this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
		levelnumber++;
		SceneManager.LoadScene (levelnumber);
	}
	void Update () {
		if (this.gameObject.transform.localScale.x <= -4) {
			reversed = true;
			forward = false;
		}
		if (this.gameObject.transform.localScale.x >= 4) {
			forward = true;
			reversed = false;
		}
		if (reversed == false && forward ==true)
			this.gameObject.transform.localScale -= new Vector3 (0.1f,0,0);
		if (reversed == true && forward == false)
			this.gameObject.transform.localScale += new Vector3 (0.1f,0,0);
	}
}
