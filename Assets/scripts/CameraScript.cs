using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;//wektor 3 zmiennych
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        transform.rotation = player.rotation;
    }
}
