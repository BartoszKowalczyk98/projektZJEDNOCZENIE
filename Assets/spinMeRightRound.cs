using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinMeRightRound : MonoBehaviour
{

    public float spinforce;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, spinforce * Time.deltaTime, 0);
    }
}
