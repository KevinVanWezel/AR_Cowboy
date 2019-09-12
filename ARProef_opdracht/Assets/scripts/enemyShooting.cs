using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public bool Shooting = false;
    [SerializeField]
    private GameObject _projectile;

    [SerializeField]
    private Transform _Spawnpoint;

    [SerializeField]
    private float _fireRate;
    private float _nextFireTime;
    // Start is called before the first frame update
    void Update()
    {
        if (Time.time >= _nextFireTime)
        {
            Shooting = false;
        }
        print(Shooting);
    }
    public void Shoot()
    {
        if (!Shooting)
        {
 
            Instantiate(_projectile, _Spawnpoint.position, _Spawnpoint.rotation);
            _nextFireTime = Time.time + _fireRate;
            Shooting = true;
        }

    }

    
}
