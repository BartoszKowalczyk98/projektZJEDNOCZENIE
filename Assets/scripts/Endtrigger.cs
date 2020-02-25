
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("zladroga") && other.CompareTag("Player")){
            gameManager.uchwytrowerka.SetActive(false);
            gameManager.animator.SetTrigger("zladroga");
            gameManager.Invoke("Restart", gameManager.restartdelay);
        }
        else if (this.CompareTag("samochod") && other.CompareTag("Player"))
        {
            gameManager.EndGame2();
            /*
            gameManager.uchwytrowerka.SetActive(false);
            gameManager.animator.SetTrigger("kolizja");
            gameManager.Invoke("Restart", gameManager.restartdelay);*/
        }
        else if(other.CompareTag("Player"))
            gameManager.CompleteLevel();
    }
}
