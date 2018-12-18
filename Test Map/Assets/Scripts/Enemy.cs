using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public NavMeshAgent nav;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		//Keep track of time passed
		float t = Time.time - startTime;
		//Alter speed based on time elapsed(in sec)
		if (t < 60f) {
			nav.speed = 1f;
		} 
		if (t >= 60f) {
			nav.speed = 2f;
		}
		if (t >= 120f) {
			nav.speed = 3f;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject.Find("TimerText").SendMessage("lossCondition");
	}
}
