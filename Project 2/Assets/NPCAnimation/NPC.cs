using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    [Header("Movement")]
    private Rigidbody rb;
    public bool isWaiting;

    public float minX = 494;
    public float maxX = 505;
    public float minZ = 495;
    public float maxZ = 505;


    Vector3 currentDestination;
    NavMeshAgent agent;
    public float minimumDistance = 5f;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        currentDestination = randomPosition();
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
    }
    // Update is called once per frame
    void Update()
    { 
        agent.destination = currentDestination;
        if (Vector3.Distance(transform.position, currentDestination) < minimumDistance && !isWaiting)
        {
            StartCoroutine(Wait()); 
           
        }
    }
    IEnumerator Wait()
    {
        isWaiting = true;
        anim.SetBool("isWalking", false);
        currentDestination = transform.position;
        yield return new WaitForSeconds(Random.Range(1,10));
        isWaiting = false;
        anim.SetBool("isWalking", true);
        currentDestination = randomPosition();
    }
    Vector3 randomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 randomPosition = new Vector3(randomX, 0, randomZ);
        return randomPosition;
    }
    
}

