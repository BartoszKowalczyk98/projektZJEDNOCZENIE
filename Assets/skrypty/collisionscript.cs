using UnityEngine;

public class collisionscript : MonoBehaviour
{
    public poruszanie chodzenie;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            chodzenie.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
