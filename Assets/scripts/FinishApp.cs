using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishApp : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("koniec aplikacji");
        Application.Quit();
    }
}
