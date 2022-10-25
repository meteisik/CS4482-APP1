using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   
    public Transform circle_spawn;
    public GameObject circle;
    public float circle_speed =30;

    void Update()
    {
float horizontalInput = Input.GetAxis("Horizontal");


        if(Input.GetKeyDown(KeyCode.Mouse0))
        {


            var bullet = Instantiate(circle, circle_spawn.position, circle_spawn.rotation);

            if (horizontalInput > 0.01f)
            bullet.GetComponent<Rigidbody2D>().velocity = circle_spawn.right*circle_speed;
            
            if (horizontalInput < -0.01f)
            bullet.GetComponent<Rigidbody2D>().velocity = -circle_spawn.right*circle_speed;
        }







    }



 
}
