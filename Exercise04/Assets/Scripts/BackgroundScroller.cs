using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {
  
	public float speed = 0;

	float pos = 0;

	void Start () {
	}

    void Update()
    {
		pos += speed;

		if (pos > 1.0f) {
			pos -= 1.0f;
		}

		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (pos, 0);
    }
}
