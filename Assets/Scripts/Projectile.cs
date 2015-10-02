using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float Damage {
		set;
		get;
	}

	// Use this for initialization
	void Start () {
		Damage = 50;
	}


	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col){
		
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemy") {
			col.gameObject.GetComponent<Stats> ().ApplyDamage (Damage);
		}
		Debug.Log ("colidiu");
		
		Destroy (gameObject);
	}
}
