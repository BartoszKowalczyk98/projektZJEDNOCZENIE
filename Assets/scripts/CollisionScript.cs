using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public MovementScript chodzenie;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")//zderzenie z trawa i budynkami
        {
            chodzenie.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (collision.collider.tag == "samochod")//zderzenie z samochodem
        {
            chodzenie.enabled = false;
            FindObjectOfType<GameManager>().EndGame2();
        }
    }
}
