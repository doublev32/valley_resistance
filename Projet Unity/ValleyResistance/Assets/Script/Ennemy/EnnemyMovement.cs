using UnityEngine;
using System.Collections;

public class EnnemyMovement : MonoBehaviour {
    Transform player;
    NavMeshAgent nav;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("TownHall").transform;
        nav = GetComponent <NavMeshAgent> ();
    }


    void Update ()
    {
        nav.SetDestination(player.position);
    }
}
