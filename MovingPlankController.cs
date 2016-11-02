using UnityEngine;
using System.Collections;

public class MovingPlankController : MonoBehaviour {
	public bool Vertical = false;
	public float speed;
	public float distance;
	bool wayback;
	float start;

	void Start(){
		if (Vertical == true)
			start = this.gameObject.transform.position.y;
		if (Vertical == false)
			start = this.gameObject.transform.position.x;
	}
	void Update () {
		if ((Vertical == true && this.gameObject.transform.position.y > start + distance) || (Vertical == false && this.gameObject.transform.position.x > start + distance))
			wayback = true;
		if ((Vertical == true && Mathf.Round(start) == Mathf.Round (this.gameObject.transform.position.y)) || (Vertical == false && Mathf.Round(start) == Mathf.Round(this.gameObject.transform.position.x))) {
			wayback = false;
		}
		if (wayback == true) {
			if (Vertical == true)
				this.gameObject.transform.position += (new Vector3 (0,Mathf.Lerp (0, speed, Time.deltaTime),0) * -1);
			if (Vertical == false)
				this.gameObject.transform.position += (new Vector3 (Mathf.Lerp (0, speed, Time.deltaTime),0,0) * -1);
		} 
		if (wayback ==false){
			if (Vertical == true)
				this.gameObject.transform.position += new Vector3 (0, Mathf.Lerp (0, speed, Time.deltaTime), 0);
			if (Vertical == false)
				this.gameObject.transform.position += new Vector3 (Mathf.Lerp (0, speed, Time.deltaTime), 0, 0);
		}
	}


}
