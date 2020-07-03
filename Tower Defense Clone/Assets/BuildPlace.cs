using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlace : MonoBehaviour
{
    public GameObject towerPrefab;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    void OnMouseUpAsButton()
    {

        GameObject g = (GameObject)Instantiate(towerPrefab);
        g.transform.position = transform.position + Vector3.up;
        print("Haha");

    }
}
