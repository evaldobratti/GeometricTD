using UnityEngine;
using System.Collections;

public class Path : MonoBehaviour {

	private NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();

		agent.SetDestination (GameObject.Find("Objective").transform.position);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
