using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Playables;






public class PhotonTimelineView : MonoBehaviourPunCallbacks
{
    [SerializeField]
    bool _start;

    private ExitGames.Client.Photon.Hashtable _mycustomProperties = new ExitGames.Client.Photon.Hashtable();
    public PlayableDirector pDirector;
    // Start is called before the first frame update
    public void cProperties()
    {
        //bool _start = false;
        _mycustomProperties["sTimeline"] = _start;
        PhotonNetwork.LocalPlayer.CustomProperties = _mycustomProperties;


    }
    public void sButton()
    {
        _start = true;
        sTimeline();
        Debug.Log(_mycustomProperties);
        
    }

    
    public void sTimeline()
    {
        pDirector.Play();
    }

    

}
