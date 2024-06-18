using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class NPCControls : MonoBehaviour
{
    public float speed;
    public float rightBound;
    public string [] randomButton;
    public int buttonIndex;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Begging Area"))
        {
           int buttonIndex = Random.Range(0, randomButton.Length); // generate random button from randomButton Index.

           Debug.Log("In begging Area");

            //Debug.Log("Money Gained");

        }
    }


}

