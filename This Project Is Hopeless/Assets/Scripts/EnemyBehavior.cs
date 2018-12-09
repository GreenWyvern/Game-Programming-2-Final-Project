using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    NavMeshAgent navAgent;
    NavMeshObstacle navOb;

    private bool alive = true;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        navOb = GetComponent<NavMeshObstacle>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            navAgent.destination = player.transform.position;
        }
        else
        {

        }
        
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "sword")
        {
            navAgent.enabled = false;
            navOb.enabled = true;
            Debug.Log("oof");
            alive = false;
        }
    }
}
