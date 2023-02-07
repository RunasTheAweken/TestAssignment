using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attack;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player") 
        {
            Health hpplayer = collision.gameObject.GetComponent<Health>();
            hpplayer.TakeDamagePlayer(20);
        }
    }
}
