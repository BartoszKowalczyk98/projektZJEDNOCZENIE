﻿
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("zladroga") && other.CompareTag("Player")){
            gameManager.animator.SetTrigger("zladroga");//zladroga
            gameManager.Invoke("Restart", gameManager.restartdelay);
        }
        else if (this.CompareTag("Obstacle") && other.CompareTag("Player")){
            gameManager.animator.SetTrigger("kolizja");//kolizja
            gameManager.Invoke("Restart", gameManager.restartdelay);
        }
        else if(other.CompareTag("Player"))
            gameManager.CompleteLevel();
    }
}
