using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

    public Slider healthBar;
	public int life;

    public enum  BossStates
    {
        Idle,
        Attacking,
        Dashing,
        Dead,
        Moving
    };

    public BossStates currentState = BossStates.Idle;

	void Start () {
	}

    void OnCollisionEnter2D(Collision2D collision)
    { 
		if (collision.gameObject.name == "Bullet") {
			healthBar.value -= 5;
			Destroy (collision.gameObject);
		}
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Update () {
        switch (currentState)
        {
            case BossStates.Idle:

            break;
        }
    }

    void FixedUpdate()
	{}
}
