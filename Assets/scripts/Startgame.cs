using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{

    Playercontrolls controlls;
    private int ktorascena;
    private bool clickable = false;
    public void cursorOnButton(int nrsceny)
    {
        clickable = true;
        ktorascena = nrsceny;
    }
    public void cursorOffButton()
    {
        clickable = false;
    }
    private void Awake()
    {
        controlls = new Playercontrolls();
        controlls.actionmap.click.performed += ctx => sceneloadingMethod();
    }
    private void sceneloadingMethod()
    {
        if(clickable)
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
