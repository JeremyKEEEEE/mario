using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public Transform firePoint;
    [SerializeField] public GameObject bulletPrefab;
    // Update is called once per frame
    
    void Update()
    {
        if(Input.GetKey("f"))
        {
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        }
    }
}