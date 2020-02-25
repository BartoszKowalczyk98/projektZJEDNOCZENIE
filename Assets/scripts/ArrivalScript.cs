using UnityEngine;

public class ArrivalScript : MonoBehaviour
{
    public Animator animator;
    
    void OnTriggerEnter(Collider other)
    {
        animator.SetBool("dojechali", true);
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetBool("dojechali", false);
    }
    
}
