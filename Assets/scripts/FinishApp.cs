using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishApp : MonoBehaviour
{
    private bool closable = false;
    private bool menuable = false;
    private void coontrollerHandler()
    {
        if (closable)
        {
            //Debug.Log("koniec");
            Application.Quit();
        }
        else if(menuable)
        {
            SceneManager.LoadScene(0);
        }
            
    }

    Playercontrolls controlls;
    
    public void cursorOnButtonExit( )
    {
        closable = true;
    }
    public void cursorOffButtonExit()
    {
        closable = false;
    }

    public void cursorOnButtonMenu()
    {
        menuable = true;
    }

    public void cursorOffButtonMenu()
    {
        menuable = false;
    }


    private void Awake()
    {
        controlls = new Playercontrolls();
        controlls.actionmap.click.performed += ctx => coontrollerHandler();
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
