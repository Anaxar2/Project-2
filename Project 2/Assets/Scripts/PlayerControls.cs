using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Movement")]
    public Rigidbody rb;
    public float speed = 5f;
    public float turnSpeed = 45f;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();
    anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float horInput = Input.GetAxis("Horizontal") * speed;
        float verInput = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector3(horInput, 0, verInput);
    }
}

