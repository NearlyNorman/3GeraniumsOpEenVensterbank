using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSituation : MonoBehaviour
{
    public GameObject[] ThingsThatNeedToBeOn;

    public GameObject[] ThingsThatNeedToBeOff;
    
    private void Awake()
    {
        foreach (var item in ThingsThatNeedToBeOn)
        {
            item.SetActive(true);

        }

        foreach(var item in ThingsThatNeedToBeOff)
        {
            item.SetActive(false);

        }
    }
}
