using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    private float enemySpeed = 2f;

    private int fleetWidth = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }
    
    private void Move()
    {
        
        if (transform.position.x < (-7f + fleetWidth) || transform.position.x > (7f - fleetWidth)) 
        {
            var vector3 = transform.position;
            vector3.y = transform.position.y - 1;
            transform.position = vector3;
            enemySpeed = enemySpeed * -1;
        }
        transform.Translate(Vector2.left * (enemySpeed * Time.deltaTime));
    }


}
