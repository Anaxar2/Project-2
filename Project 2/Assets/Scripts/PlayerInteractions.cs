using System.Collections;
using System.Collections.Generic;
using UnityEngine;


+public class PlayerInteractions : MonoBehaviour
{
    [Header("Player")]
    private Transform player;

    [Header("Pickpocketing")]
    public float pickPocketRange = 3; // sets range for pickpocket to be enabled.
    public int pickPocketTime = 5; // how long it takes to pickpocket.

    [Header("Begging")]
    private Transform beggingSpot;
    public float beggingRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Need access to the player.
        player = transform;

    }
    // Update is called once per frame
    void Update()
    {
        PickPocketing();
        Begging();
    }
    public void Begging()
    {
        // if (player position is less than or equal to begging range)
        {
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject.FindGameObjectWithTag("Begging");
           
            if (Vector3.Distance(player.position, beggingSpot.position) < beggingRange)
            {
                Debug.Log("Begging Started");
            }
            else
        {
            Debug.Log("No Target");
        }
        }
        
        
        
    }
    public void PickPocketing() // If player is within range of NPC and holding down the E key, activate pickpocket mechanic.
    {
        if (Input.GetKey(KeyCode.E))

        {
            /* //pickpocket mechanic to take money
             Vector3.Distance(player.position pickPocketRange);
             Debug.Log("Pickpocket Succesful");
            }
            else
            {
                Debug.Log("No Targets");
            }*/
        }
    }
}