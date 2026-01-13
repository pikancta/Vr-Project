using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class RecordPlayer : MonoBehaviour
{
    public XRSocketInteractor Socket;
    public RecordSpin spin;

    public GameObject CurrentRecord;
    public AudioSource CurrentSong;
    

    public void AttachRecord()
    {
        CurrentRecord = Socket.interactablesSelected[0].transform.gameObject;
        CurrentSong = CurrentRecord.GetComponent<AudioSource>();
        if (CurrentRecord != null )
        {
            CurrentSong.Play();
            spin.enabled = true;
        }
    }

    public void DetachRecord()
    {
        if (CurrentSong != null)
        {
            CurrentSong.Stop();
            CurrentSong = null;
        }
        spin.enabled = false;
        CurrentRecord = null;

    }

}
