using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movementSpeed;
        }
        
    }
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Wall")
        {
            print("testtt");
            movementSpeed = -0.1f;
        }
    }
    void OnCollisionExit(Collision collider)
    {
        movementSpeed = 0.1f;
    }
    
    }
