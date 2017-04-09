using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    Text text;

	void Start () {
        score = 0;
        text = GetComponent<Text>();
	}

    void OnGUI()
    {
		text.text = "Score: " + ScoreManager.score;
    }

    void Update () {
       
	}
}
