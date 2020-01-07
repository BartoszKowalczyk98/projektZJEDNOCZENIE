
using UnityEngine;

public class ShowSignInfoScript : MonoBehaviour
{
    public Canvas infoOZnaku;
    public float delay = 0.5f;
    public void showInfo()
    {
        infoOZnaku.enabled = true;
    }
    public void hideInfo()
    {
        Invoke("disable", delay);
    }
    private void disable()
    {
        infoOZnaku.enabled = false;
    }
}
