using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    GameObject Player;
    NavMeshAgent enemy;


     void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");


        if(Player == null)
        {
            Debug.Log("tag player");
        }

       enemy = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Player != null)
        enemy.destination = Player.transform.position;
    }

    // transform. forward gebruiken met time. delta time
    //navmesh gebruiken
    //navmes op component zetten
    //chek er op zetten over distance 
    //bullet kan naar emty toe gaan in speler
}

   
    


