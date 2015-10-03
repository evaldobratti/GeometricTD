using UnityEngine;
using System.Collections;

public class TowerPlacer : MonoBehaviour {

	public GameObject tower;
	void Start () {
	
	}

	public static GameObject placingObject = null;

	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition );
		Debug.DrawRay (ray.origin, ray.direction * 900, Color.green);
		if (placingObject == null) {

			Debug.Log("Criou");
			placingObject = GameObject.Instantiate (tower) as GameObject;
		} else {
			Debug.Log("placing");

			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.tag.Equals("Building"))
					placingObject.transform.position = hit.point;
			}


		}


	}
}
