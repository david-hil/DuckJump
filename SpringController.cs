using UnityEngine;
using System.Collections;

public class SpringController : MonoBehaviour {
	Vector2 springJump;
	bool pressed = false;
	public int counter = 8;

	void Start () {
		springJump = new Vector2 (0f, 900f);
	}
	
	void Update () {
		if (pressed == true)
			counter -= 1;
		if (counter == 0) {
			expand ();
			counter = 5;
			pressed = false;
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		col.gameObject.GetComponent<Rigidbody2D> ().AddForce (springJump);
		press ();
	}

	void press () {
		Vector3 position;
		this.gameObject.transform.localScale = new Vector3(2,1,1);
		this.gameObject.transform.position -= Vector3.up;
		pressed = true;
	}
	void expand () {
		this.gameObject.transform.localScale = (new Vector3 (2,2,1));
		this.gameObject.transform.position += Vector3.up;
	}
}
