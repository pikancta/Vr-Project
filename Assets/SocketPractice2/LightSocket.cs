using UnityEngine;
//Tell unity to use the xr Libary
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class LightSocket : MonoBehaviour
{
    public XRSocketInteractor socket;
    public Light lightbulb;
    public GameObject AttatchedObject;

    public void AttachObject()
    {
        lightbulb.enabled = true;
        AttatchedObject = socket.interactablesSelected[0].transform.gameObject;
        if(AttatchedObject.CompareTag("Red"))
        {
            lightbulb.color = Color.red;
        }

        else if (AttatchedObject.CompareTag("Green"))
        {
            lightbulb.color = Color.green;
        }

        else if (AttatchedObject.CompareTag("Orange"))
        {
            lightbulb.color = Color.yellow;
        }
        else
        {
            lightbulb.color = Color.white;
        }
    }

    public void DetachObject()
    {
        lightbulb.enabled = false;
        AttatchedObject = null;
    }

}
