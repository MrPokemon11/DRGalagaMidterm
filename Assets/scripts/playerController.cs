using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float playerSpeed = 0.1f;
    GameObject bullet;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GameObject.Find("PlayerBullet");
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * (playerSpeed * Time.deltaTime));
        if (transform.position.x < -7f)
        {
            var vector3 = transform.position;
            vector3.x = -7f;
            transform.position = vector3;
        }
    }

    private void MoveRight()
    {
        transform.Translate(Vector2.right * (playerSpeed * Time.deltaTime));
        if (transform.position.x > 7f)
        {
            var vector3 = transform.position;
            vector3.x = 7f;
            transform.position = vector3;
        }
    }

    private void Fire()
    {
        GameObject fire = Instantiate(bullet, player.transform.position, player.transform.rotation);
        fire.tag = "Bullet";
    }
}
