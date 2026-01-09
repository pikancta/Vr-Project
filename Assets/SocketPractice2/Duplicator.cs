using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Duplicator : MonoBehaviour
{
    public XRSocketInteractor socket;
    public Transform spawnPoint;
    public GameObject AttachedObject;

    public void AttachObject()
    {
        AttachedObject = socket.interactablesSelected[0].transform.gameObject;
       GameObject currentObject = Instantiate(AttachedObject, spawnPoint.position, spawnPoint.rotation);
        currentObject.GetComponent<Rigidbody>().isKinematic = false;
        currentObject.GetComponent <Rigidbody>().useGravity = true;
    }



    public void DetachObject()
    {

    }
}
