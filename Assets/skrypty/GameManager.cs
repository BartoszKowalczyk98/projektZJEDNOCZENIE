﻿using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartdelay = 1f;
    public Text scoretext;

    public GameObject completelevelUI;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;

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
        completelevelUI.SetActive(true); 
    }
}
