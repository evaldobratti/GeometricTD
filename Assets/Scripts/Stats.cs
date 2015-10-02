using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	public int life = 100;
	public int armor = 0;

	private float currentLife;
	private float armorReduction;
	// Use this for initialization
	void Start () {
		currentLife = life;
		armorReduction = 1 - (armor / 100);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentLife <= 0)
			Destroy (gameObject);
	}

	public void ApplyDamage(float damage) {

		currentLife = currentLife - (armorReduction * damage);
	}
}
