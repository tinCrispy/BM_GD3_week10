using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.ProBuilder;

public class AIController : MonoBehaviour
{
    Transform player;
    [SerializeField] float followRadius;
    NavMeshAgent agent;

    Vector3 randomTarget, currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<RaycastShoot>().transform;
        agent = GetComponent<NavMeshAgent>();

        randomTarget = new Vector3(transform.position.x + (Random.Range(-10, 10)), transform.position.y, transform.position.z + (Random.Range(-10, 10)));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) > followRadius)
        {
            search();
        }
        else
        {
            followPlayer();
        }

        if (Vector3.Distance(transform.position, player.position) < 1)
        {
            attack();
        }

        if (Vector3.Distance(transform.position, randomTarget) < 1)
        {
            randomTarget = new Vector3(transform.position.x + (Random.Range(-10, 10)), transform.position.y, transform.position.z + (Random.Range(-10, 10)));
        }
    }

    void followPlayer()
    {
        agent.SetDestination(player.position);
    }

    void search()
    {
        agent.SetDestination(randomTarget);

    }

    void attack()
    {

    }

}

