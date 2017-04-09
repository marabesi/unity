using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	void Start()
	{
		name = "Bullet";
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


	void OnCollisionEnter2D(Collision coll) {
		
	}
}
