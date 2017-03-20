using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;     // Temps entre chaque attque
    public int attackDamage = 10;               // Degats de l'attaque

    GameObject target;                          // La cible
    PlayerHealths targetHealth;               // Reference au point de vie de la cible.
    //EnemyHealth enemyHealth;                  // Reference au point de vie de l'ennemie.

    bool targetInRange;                         // Si le joueur se trouve dans la zone 
    float timer;                                // Timer pour la periode entre chaque attaque

    void Awake()
    {
        // Initialise les references
        //enemyHealth = GetComponent<EnemyHealth>();
    }

    void OnCollisionEnter(Collision col)
    {
        //S'il rentre en contact avec un objet
        if (col.gameObject.tag == "Building" || col.gameObject.tag == "Soldier" || col.gameObject.tag == "TownHall")
        {
            //Donne les référence de la cible 
            target = col.gameObject;
            targetHealth = target.GetComponent<PlayerHealths>();
            targetInRange = true;
        }
        else 
        {
            target = null;
            targetHealth = null;
            targetInRange = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks && targetInRange)
        {
            Attack();
            Debug.Log("attack");
        }
    }


    void Attack()
    {
        // Reset le timer.
        timer = 0f;

        //La cible prend des dommage
        if (targetHealth.currentHealth > 0)
        {
            targetHealth.TakeDamage(attackDamage);
        }
    }
}
