using UnityEngine;

public class IncomingPlayerScript : MonoBehaviour
{
    public Animator animator;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            animator.SetBool("nadjezdza", true);
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            animator.SetBool("nadjezdza", false);
    }
}
