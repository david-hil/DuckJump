using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed = 10.0f;
	Vector2 jump;
	float ypositionlast = -34.71f;

	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody2D> ();
		jump  = new Vector2 (10f, 45f);
	}
	
	void Update () {
		Vector2 movement = new Vector2 ((Input.GetAxis ("Horizontal")* speed), 0);
		rb.AddForce(movement);
		if (Input.GetButtonDown ("Jump") && (ypositionlast + 0.025f > this.gameObject.transform.position.y && ypositionlast - 0.025f < this.gameObject.transform.position.y)) {
			Jump ();
		} 
		if (this.gameObject.transform.position.y < -60 || Input.GetButtonDown("Reset")) {
			SceneManager.LoadScene (0);
		}
		ypositionlast = this.gameObject.transform.position.y;
	}
	void Jump (){
		rb.AddForce (jump*speed);
	
	}

}
