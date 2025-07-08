using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator toOpen;

    void Start()
    {
        button.enabled = false;
        toOpen.enabled = false;
    }
 
    private void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        toOpen.enabled = true;
    }
}

