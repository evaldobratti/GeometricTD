using UnityEngine;
using System.Collections;

public class CreepSpawner : MonoBehaviour {


	public GameObject creep;


	// Use this for initialization
	void Start () {
		StartCoroutine (Spawn());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator Spawn() {
		while (true) {
			GameObject.Instantiate(creep, transform.position, transform.rotation);
			yield return new WaitForSeconds(2);

		}
	}
}
