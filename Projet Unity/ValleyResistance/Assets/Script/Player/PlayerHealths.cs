using UnityEngine;
using System.Collections;

public class PlayerHealths : MonoBehaviour {

    public int startingHealth = 100; //point de vie de début
    public int currentHealth; //point de vie actuelle

    bool isDestroy; //indique si le batiment est detruit

    void Start()
    {
        //initialise les points de vie
        currentHealth = startingHealth;
    }

    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        // Deduit les degat de dommage au point de vie
        currentHealth -= amount;

        //si les point de vie sont à zero détruit l'objet
        if (currentHealth <= 0 && !isDestroy)
        {
            DestroyBuilding();
        }
    }


    void DestroyBuilding()
    {
        //met l'objet
        isDestroy = true;
        Destroy(transform.gameObject);
    }  
}
