using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontrollerscript : MonoBehaviour
{
    Playercontrolls controlls;
    Vector2 wektorporuszania;
    Vector2 wektorobrotu;


    public Rigidbody rb;
    public float silaprzod;
    public float silabok;
    public float movementspeed;
    public Transform rower;
    private Vector4 zerowy;

    private void Awake()
    {
        controlls = new Playercontrolls();


        controlls.actionmap.move.performed += ctx => wektorporuszania = ctx.ReadValue<Vector2>();
        controlls.actionmap.move.canceled += ctx => wektorporuszania = Vector2.zero;
        controlls.actionmap.rotate.performed += ctx => wektorobrotu = ctx.ReadValue<Vector2>();
        controlls.actionmap.rotate.canceled += ctx => wektorobrotu= Vector2.zero;
    }

    private void Update()
    {
        Vector3 m = new Vector3(0, 0, wektorporuszania.y) * Time.deltaTime;
        m.z *= silaprzod;
        rb.AddRelativeForce(m);
        if (!m.Equals(Vector3.zero))
        {
            Vector2 r = new Vector2(0, wektorobrotu.x) * Time.deltaTime * 100f;
            transform.Rotate(r, Space.World);
        }
        if (wektorporuszania.y!=0) 
        {
            for (int i = 0; i < rower.childCount; i++)
            {
                Transform komponent = rower.GetChild(i);
                if (komponent.name.Contains("Circle"))
                {
                    komponent.Rotate(new Vector3(0, 0, -wektorporuszania.y), Space.Self);
                }
            }
        }

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
