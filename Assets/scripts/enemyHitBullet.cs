using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHitBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Console.Write("hit");
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
    
    
}
