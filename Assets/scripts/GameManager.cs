using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartdelay = 0.5f;
    public Animator animator;
    public GameObject uchwytrowerka;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            uchwytrowerka.SetActive(false);
            gameHasEnded = true;
            animator.SetTrigger("trawaiinne");//wjechanie na trawe albo w budynek 
            Invoke("Restart", restartdelay);
        }

    }
    public void EndGame2()
    {
        if (!gameHasEnded)
        {
            uchwytrowerka.SetActive(false);
            gameHasEnded = true;
            animator.SetTrigger("kolizja");//kolizja z samochodem czy to stojącym czy to co
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
        uchwytrowerka.SetActive(false);
        animator.SetTrigger("fadeouter");
        Invoke("loadnext", restartdelay);
    }
    void loadnext() 
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(0);
    }
}
