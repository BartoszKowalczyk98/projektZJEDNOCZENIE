using UnityEngine;

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
            rb.AddForce(Input.GetAxis("Horizontal") * silabok * Time.deltaTime * Camera.main.transform.forward.x, 0, 0, ForceMode.VelocityChange);
  
        }

        else if (Input.GetButton("Vertical"))
        {
            /*rb.AddForce(0, 0, Input.GetAxis("Vertical") * silaprzod * Time.deltaTime);*/
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
