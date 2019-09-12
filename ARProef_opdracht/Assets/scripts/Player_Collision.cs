using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    [SerializeField]
    private TimelineActivator Tijdlijn;
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "bullet")
        {
            Tijdlijn.playcow();
        }
    }
}
