using UnityEngine;
using System.Collections;

public class AbstractTower : MonoBehaviour {

	public GameObject alvo;
	// Use this for initialization

	private GameObject lastObject;
	private GameObject canon;
	private Quaternion initialRotation;

	private Gun gun;
	void Start () {
		canon = GameObject.Find ("Canon");
		initialRotation = canon.transform.rotation;
		gun = GetComponent<Gun> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*Quaternion spreadAngle = Quaternion.AngleAxis(-15, transform.up);
		Vector3 newVector = spreadAngle * transform.forward;*/

		RaycastHit hit;
		if (Physics.Raycast (new Ray (canon.transform.position, canon.transform.forward), out hit, 30) && hit.collider.tag.Equals ("Enemy")) {
			Debug.DrawLine (canon.transform.position, hit.transform.position, Color.green);
			Vector3 lookTo = hit.transform.position - canon.transform.position;
			lookTo.y = 0;
			Quaternion rotation = Quaternion.LookRotation (lookTo);

			canon.transform.rotation = Quaternion.Slerp (canon.transform.rotation, rotation, 1);

			gun.Shoot(hit.collider.transform.position, 10);
		} else {
			canon.transform.rotation = Quaternion.Slerp (canon.transform.rotation, initialRotation, Time.deltaTime);
		}



		/*Debug.DrawLine(alvo.transform.position, transform.position, Color.green);
		Vector3 lookTo = alvo.transform.position - transform.position;
		lookTo.y = 0;

		Quaternion rotation = Quaternion.LookRotation(lookTo);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);*/
	}
}
