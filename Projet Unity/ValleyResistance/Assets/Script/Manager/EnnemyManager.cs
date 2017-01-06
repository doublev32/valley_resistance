using UnityEngine;
using System.Collections;

public class EnnemyManager : MonoBehaviour
{
    public GameObject[] ennemy;     // liste d'ennemies à spawn
    public float spawnTime = 3f;    //temps entre chaque spawn
    public Transform[] spawnPoints; //point de spawn à définir sur la carte


    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length); // choisi un point de spawn aleatoire
        int ennemyIndex = Random.Range(0, ennemy.Length);       // choisi un ennemy aleatoire

        Instantiate(ennemy[ennemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);// créer un ennemy
    }


}
