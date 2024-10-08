using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletManager : MonoBehaviour
{
    public float bulletSpeed = 1f;
    private GameObject bullet;
    private GameObject bullet2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

                transform.Translate(Vector2.up * (bulletSpeed * Time.deltaTime));
                if (transform.position.y is > 9 or < -7 && gameObject != bullet)
                {
                    Destroy(this.gameObject);
                }


        
    }
}
