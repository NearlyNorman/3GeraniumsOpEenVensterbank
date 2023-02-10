using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timelinestarter : MonoBehaviour
{
    public PlayableDirector pDirector;
    public float Forward;
    public float Backward;

    bool PressL;
    bool PressR;

    bool SpoelDoor;
    bool SpoelTerug;

    void Update()
    {
        PressR = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        PressL = OVRInput.Get(OVRInput.RawButton.LIndexTrigger);

        if (PressL == true && PressR == true)
        {
            pDirector.Play();
        }

        SpoelDoor = OVRInput.Get(OVRInput.RawButton.RHandTrigger); 
        SpoelTerug = OVRInput.Get(OVRInput.RawButton.LHandTrigger);

        if (SpoelDoor == true)
        {
            pDirector.time += 1f;
        }

        else if (SpoelDoor == false)
        {
            pDirector.playableGraph.GetRootPlayable(0).SetSpeed(1);
        }


        if (SpoelTerug == true)
        {
            pDirector.playableGraph.GetRootPlayable(0).SetSpeed(Backward);
        }

        else if (SpoelTerug == false)
        {
            pDirector.playableGraph.GetRootPlayable(0).SetSpeed(1);
        }
    }
}
