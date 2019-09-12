using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField]
    private TimelineActivator Tijdlijn;
    public float rotationSpeed;
    public float Distance;
    public bool Found;
    private enemyNotFound detect;

    void Awake()
    {
       // detect = GetComponent<enemyNotFound>();
        Found = false;
    }

    void Update()
    {
        if (!Found)
            transform.Rotate(0, rotationSpeed, 0);

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 1000))
        {
            Found = true;


        }
    }
        void OnCollisionEnter(Collision collider)
        {
            if (collider.gameObject.tag == "bullet_Gunmen")
            {
                Tijdlijn.playgun();
            }
        }


    
}
