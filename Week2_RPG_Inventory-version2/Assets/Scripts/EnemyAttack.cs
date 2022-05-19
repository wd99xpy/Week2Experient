using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private PlayerController player;
    //private bool attackable = true;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            player.health--;
            //attackable = false;
            Debug.Log("Player be attacked!");
        }
        // if (!attackable&&other.gameObject.CompareTag("Player")) {
        //     attackable = true;
        // }
    }


}
