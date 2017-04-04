using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }

    IEnumerator EnemyDeath()
    {
        yield return null;
    }
}
