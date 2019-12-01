﻿using UnityEngine;

public class poruszanie : MonoBehaviour
{
    public Rigidbody rb;


    public float silaprzod;
    public float silabok;
    public float movementspeed;
    
    void FixedUpdate()//ponoc lepsze przy fizyce i dodawaniu predkosci
    {

        if (Input.GetButton("Horizontal"))
        {
            transform.position = transform.position + Input.GetAxis("Horizontal") * Camera.main.transform.right * movementspeed * Time.deltaTime;
        }

        else if (Input.GetButton("Vertical"))
        {
            transform.position = transform.position + Input.GetAxis("Vertical")*Camera.main.transform.forward * movementspeed * Time.deltaTime;
        }

        else if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(0, 10*silaprzod * Time.deltaTime, 0);
        }

        else if (Input.touchCount > 1)
        {
            transform.position = transform.position +  Camera.main.transform.forward * movementspeed * Time.deltaTime;
        }
      
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
        
    }

    
}
