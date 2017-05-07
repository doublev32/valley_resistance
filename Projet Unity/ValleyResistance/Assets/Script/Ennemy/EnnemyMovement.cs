using UnityEngine;
using System.Collections;

public class EnnemyMovement : MonoBehaviour {
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("TownHall").transform;
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        nav.SetDestination(player.position);
    }
}
