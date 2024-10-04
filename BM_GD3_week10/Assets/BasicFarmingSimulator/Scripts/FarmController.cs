using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.AI;

public class FarmController : MonoBehaviour
{
    public GameObject tractor;
    public GameObject harvester;
    public GameObject cabbage;

    public bool isSearching;

    GameObject[] targets;

    
    
    

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        agent = GetComponent<NavMeshAgent>();
        isSearching = true;

 //       targets = FindObjectsByType(mudManager, );
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == ("Tractor") && isSearching == true)
        {
            searchMud();

        }

        if (gameObject.tag == ("Harvester") && isSearching == true)
                {
            Debug.Log("looking for cabbages...");
                    searchCabbage();

                }

    }

    void searchMud()
    {
        isSearching = false;
        Transform target = GameObject.FindGameObjectWithTag("Mud").transform;
        bool alreadyPlanted = target.GetComponent<mudManager>().isPlanted;

        if (alreadyPlanted == false)
        {
            agent.SetDestination(target.position);
            isSearching = true;
        }
        else
        {
            isSearching = true;
        }

        
       
        
        
        
    }

    void searchCabbage()
    {
            isSearching = false;
            Transform target = GameObject.FindGameObjectWithTag("PlantedMud").transform;
            bool alreadyPlanted = target.GetComponent<mudManager>().isPlanted;

            if (alreadyPlanted == true)
            {
                agent.SetDestination(target.position);
                isSearching = true;
            }
            else
            {
                isSearching = true;
            }
    }
   


}
