using UnityEngine;
using System.Collections;

public class CameraMouseController : MonoBehaviour {

	public int velocity = 10;

	private bool dragging = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			transform.position = new Vector3(transform.position.x + velocity, transform.position.y + velocity, transform.position.z + velocity);
		}

		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			transform.position = new Vector3(transform.position.x - velocity, transform.position.y - velocity, transform.position.z - velocity);
		}


		if (Input.GetMouseButtonDown(2) || dragging) {
			dragging = true;
			var h = -velocity * Input.GetAxis ("Mouse Y");
			var v = -velocity * Input.GetAxis ("Mouse X");
			transform.Translate(v,h,0);
		}

		if (Input.GetMouseButtonUp (2)) {
			dragging = false;
		}


		

	}
}
