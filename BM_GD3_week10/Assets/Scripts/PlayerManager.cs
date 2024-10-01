using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    private Button rollButton;

    public GameObject[] DicePrefab;
    public GameObject[] diceHolders;


    public int diceBanked;

    public bool roll1;


    // Start is called before the first frame update
    void Start()
    {
        rollButton = GetComponent<Button>();
        rollButton.onClick.AddListener(RollDice);

        diceBanked = 0;
        roll1 = false;

        
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RollDice()
    {
        Debug.Log("Rollin'");

        if (roll1 == false)
        {

            for (int i = 0; i < DicePrefab.Length; i++)
            {
                Instantiate(DicePrefab[i]);
                roll1 = true;
            }
        }
     //   else
    //    {
     //      GameObject[] = FindGameObjectsWithTag
     //       for
     //   }
            


    }

    private void StupidMode()
    {
        Debug.Log("Stupid");

        for (int i = 0; i < DicePrefab.Length*5; i++)
        {
             Instantiate(DicePrefab[i]);

        }


    }

}
