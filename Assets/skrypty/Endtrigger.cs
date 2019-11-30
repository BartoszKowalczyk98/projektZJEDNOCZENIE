
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(/*Collider other*/)
    {
        gameManager.CompleteLevel();
    }
}
