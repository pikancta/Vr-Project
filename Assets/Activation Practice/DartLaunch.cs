using UnityEngine;

public class DartLaunch : MonoBehaviour
{
    public float launchForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * launchForce, ForceMode.Impulse);   
    }

    
}
