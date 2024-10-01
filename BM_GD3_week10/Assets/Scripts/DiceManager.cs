using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public LayerMask GroundLayer;

    public GameObject DiePrefab;
    public int dieOutput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Physics.Raycast(transform.position, transform.forward, 1, GroundLayer))
        {
            dieOutput = 1;
        }

        if (Physics.Raycast(transform.position, -transform.forward, 1, GroundLayer))
        {
            dieOutput = 6;
        }

        if (Physics.Raycast(transform.position, transform.up, 1, GroundLayer))
        {
            dieOutput = 2;
        }

        if (Physics.Raycast(transform.position, -transform.up, 1, GroundLayer))
        {
            dieOutput = 5;
        }

        if (Physics.Raycast(transform.position, transform.right, 1, GroundLayer))
        {
            dieOutput = 3;
        }

        if (Physics.Raycast(transform.position, -transform.right, 1, GroundLayer))
        {
            dieOutput = 4;
        }
    }
}
