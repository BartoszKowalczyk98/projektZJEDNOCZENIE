using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishApp : MonoBehaviour
{
    private bool closable;
    public void Quit()
    {
        if (closable)
        {
            //Debug.Log("koniec");
            Application.Quit();
        }
            
    }

    Playercontrolls controlls;
    
    public void cursorOnButtonExit( )
    {
        closable = true;
    }
    public void currorOffButtonExit()
    {
        closable = false;
    }

    private void Awake()
    {
        controlls = new Playercontrolls();
        controlls.actionmap.click.performed += ctx => Quit();
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
