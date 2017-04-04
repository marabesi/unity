using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject settings;

	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
	}

	public void PlayPressed()
	{
		settings.SetActive(true);
	}

	public void LeaderBoardsPressed()
	{
		print("leader pressed");
	}

	public void ExtrasPressed()
	{
		print("extras pressed");
	}
}
