using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePassed : MonoBehaviour {

	public Text timeText;
	private float startTime;
	private bool lose = false;

	void Start (){
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (lose)
			return;
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f0");
		timeText.text = minutes + ":" + seconds;
	}

	public void lossCondition()
	{
		lose = true;
	}
}
