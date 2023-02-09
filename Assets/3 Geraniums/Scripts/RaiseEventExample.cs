using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;
using UnityEngine.Playables;

public class RaiseEventExample : MonoBehaviourPun
{
    private const byte START_PATRICKS_EVENT = 0;
    private MeshRenderer _mesh;
    public PlayableDirector pDirector;

    //public AudioSource aWaterkoker;
    //public AudioSource aVorkheftruck;
    //public AudioSource aKoffietas;
    //public AudioSource aGieter;
    //public AudioSource aToilet;
    //public AudioSource aKapiteinshoed;
    //public AudioSource aTV;
    //public AudioSource aGeraniums;
    //public AudioSource aLazagne;


    // Start is called before the first frame update
    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        PhotonNetwork.NetworkingClient.EventReceived += NetworkingClient_EventReceived;

        }
    private void OnDisable()
    {
        PhotonNetwork.NetworkingClient.EventReceived -= NetworkingClient_EventReceived;

    }

    private void NetworkingClient_EventReceived(ExitGames.Client.Photon.EventData obj)
    {
        if (obj.Code == START_PATRICKS_EVENT)
        {
            object[] datas = (object[])obj.CustomData;
            float i = (float)datas[0];
            

            if (i == 1)
            {
                
                pDirector.Play();
                _mesh.material.color = new Color(0, 0, 255);
            }
            else if (i == 2)
            {
                
                pDirector.Stop();
                _mesh.material.color = new Color(255, 0, 0);
            }

            else if (i == 10)
            {
                
                _mesh.material.color = new Color(255, 0, 0);
            }

            else
            {
                pDirector.Play();
            }

        }
    }
    

    public void StartPatrickLoop()
    {
        float i = 1;

       

        object[] datas = new object[] {i};
        pDirector.Play();
        _mesh.material.color = new Color(0, 0, 255);

        PhotonNetwork.RaiseEvent(START_PATRICKS_EVENT, datas, RaiseEventOptions.Default, SendOptions.SendReliable);
    }
    public void changeColor2()
    {
        float i = 2;

        _mesh.material.color = new Color(255, 0, 0);
        pDirector.Stop();


        object[] datas = new object[] {i};
        PhotonNetwork.RaiseEvent(START_PATRICKS_EVENT, datas, RaiseEventOptions.Default, SendOptions.SendReliable);
    }
    public void AudioObject1()
    {
        float i = 11;

        _mesh.material.color = new Color(255, 0, 0);
        


        object[] datas = new object[] { i };
        PhotonNetwork.RaiseEvent(START_PATRICKS_EVENT, datas, RaiseEventOptions.Default, SendOptions.SendReliable);
    }



}

