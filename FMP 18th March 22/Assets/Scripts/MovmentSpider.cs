using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovmentSpider : MonoBehaviour
{
    // Start is called before the first frame update

    GameManager gameManager;    
    public Transform goal;

    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("spider_pref");
        gameManager = gameController.GetComponent<GameManager>();

        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //agent.destination = goal.position;

    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(gameManager.moveVector * gameManager.moveSpeed * Time.deltaTime);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }



}

