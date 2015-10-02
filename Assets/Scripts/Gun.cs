using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject projectile;
	public Transform projectileSpawnPosition;
	public int projectileVelocity = 50;
	public float shootInterval = 0.5f;

	private float lastShoot;


	// Use this for initialization
	void Start () {
		lastShoot = shootInterval;
	}
	
	// Update is called once per frame
	void Update () {
		lastShoot -= Time.deltaTime;
	}

	public void Shoot(Vector3 direction, float damage) {
		if (lastShoot < 0) {
			Vector3 lookTo = direction - projectileSpawnPosition.position;

			GameObject shoot = GameObject.Instantiate (projectile, projectileSpawnPosition.position, Quaternion.LookRotation (lookTo)) as GameObject;
			shoot.GetComponent<Projectile>().Damage = damage;
			shoot.rigidbody.velocity = shoot.transform.forward * projectileVelocity;

			lastShoot = shootInterval;
		}
		
	}
}
