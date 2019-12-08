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
        Debug.Log("rotacja " + transform.rotation);
        if (!transform.rotation.Equals( Vector3.zero)) {
            m.x = transform.rotation.y * wektorporuszania.y;
        }
        Debug.Log("poruszanie "+m);
        m.z *= silaprzod;
        m.x *= silabok;
        rb.AddForce(m );

        Vector2 r = new Vector2(0, wektorobrotu.x) * Time.deltaTime * 100f;
        transform.Rotate(r, Space.World);

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
