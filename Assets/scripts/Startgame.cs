using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{

    Playercontrolls controlls;
    private int ktorascena;
    public void Starcik(int iskda)
    {
        ktorascena = iskda;
    }
    private void Awake()
    {
        controlls = new Playercontrolls();
        controlls.actionmap.click.performed += ctx => sceneloadingMethod();
    }
    private void sceneloadingMethod()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + ktorascena);
    }
    private void OnEnable()
    {
        controlls.actionmap.Enable();
    }
    private void OnDisable()
    {
        controlls.actionmap.Disable();
    }
}
