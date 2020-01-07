using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public MovementScript chodzenie;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            chodzenie.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
