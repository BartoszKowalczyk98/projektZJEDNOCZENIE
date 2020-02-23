
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            gameManager.CompleteLevel();
    }
}
