﻿using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartdelay = 0.5f;
    public Animator animator;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            animator.SetTrigger("kolizja");//kolizja
            Invoke("Restart", restartdelay);
        }

    }
    void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
    public void CompleteLevel()
    {
        animator.SetTrigger("fadeouter");
        Invoke("loadnext", restartdelay);
    }
    void loadnext() 
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(0);
    }
}
