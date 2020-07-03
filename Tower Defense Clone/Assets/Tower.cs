using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bulletPrefab;


    public float rotationSpeed = 35;

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed, Space.World);
    }

    void OnTriggerEnter(Collider co)
    {
        
        if (co.GetComponent<Monster>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = co.transform;
        }
    }
}

