using UnityEngine;

public class InjureTimmy : MonoBehaviour
{

    public Animator Animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HurtTimmy"))

        {
            Animator.SetBool("isHurt", true);
        }
    }
}
