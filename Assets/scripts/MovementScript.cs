using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody rb;


    public float silaprzod;
    public float silabok;
    public float movementspeed;
    
    void FixedUpdate()//ponoc lepsze przy fizyce i dodawaniu predkosci
    {
        if(Input.GetButton("Horizontal") && Input.GetButton("Vertical"))
        {
            rb.AddForce(Input.GetAxis("Horizontal") * Camera.main.transform.right * silabok * Time.deltaTime, ForceMode.VelocityChange);
            rb.AddForce(Input.GetAxis("Vertical") * Camera.main.transform.forward * silaprzod * Time.deltaTime);
        }
        else if (Input.GetButton("Horizontal"))
        {
            rb.AddForce(Input.GetAxis("Horizontal") * Camera.main.transform.right * silabok * Time.deltaTime,ForceMode.VelocityChange);
        }

        else if (Input.GetButton("Vertical"))
        {  
            rb.AddForce(Input.GetAxis("Vertical") * Camera.main.transform.forward * silaprzod* Time.deltaTime);
        }

        else if (Input.GetButtonDown("Jump") || Input.touchCount == 2)
        {
            rb.AddForce(0, 10*silaprzod * Time.deltaTime, 0);
        }

        else if (Input.touchCount == 1 )
        {
            transform.position = transform.position +  Camera.main.transform.forward * movementspeed * Time.deltaTime;
        }
      
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
        
    }

    
}
