using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudManager : MonoBehaviour
{
    public GameObject cabbage;
    public bool isPlanted;
    // Start is called before the first frame update
    void Start()
    {
        isPlanted = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tractor") && isPlanted == false)
        {
            StartCoroutine(growCrop());
            

           


        }
    }

    IEnumerator growCrop()
    {
        isPlanted = true;
        gameObject.tag = "PlantedMud";
        yield return new WaitForSeconds(0.5f);
        Instantiate(cabbage, transform.position, cabbage.transform.rotation);
        Debug.Log("this is now" + gameObject.tag);

    }
}
