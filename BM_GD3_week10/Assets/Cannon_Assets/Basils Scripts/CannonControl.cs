using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public int shotForce = 5;
    public int barrelRotate = 5;

    public GameObject CannonBall;

    public Transform firePoint;
    public Transform barrelEnd;

    public GameObject barrel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 firingPos = firePoint.position;
            Instantiate(CannonBall, firingPos, CannonBall.transform.rotation);
            Rigidbody rb = FindObjectOfType<CannonBall>().GetComponent<Rigidbody>();
            rb.AddForce(firePoint.forward * shotForce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))
        {
            barrel.transform.Rotate(barrelRotate * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            barrel.transform.Rotate(-barrelRotate * Time.deltaTime,0,0);
        }

    }
}

