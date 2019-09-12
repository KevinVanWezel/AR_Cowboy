using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class bullet : MonoBehaviour
{
    [SerializeField]
    private TimelineActivator Tijdlijn;
    private Timeline_Caller Timeline;
    [SerializeField]
    private float _speed;

    private Rigidbody _rigidbody;

    void Awake()
    {
        this.gameObject.transform.parent = GameObject.Find("ImageTarget").transform;
        _rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, 2f);

    }

    void FixedUpdate()
    {
        Vector3 velocity = transform.forward * _speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);


    }

   
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "barrier")
        {
            print("tset");
            Destroy(this.gameObject);
        }

        if (collider.gameObject.tag == "Player")
        {
            print("Player_death");
            Destroy(this.gameObject);
            //Tijdlijn.playgun();
        }
    }
}