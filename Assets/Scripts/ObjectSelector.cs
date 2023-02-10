using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public float Object = 0;
    public GameObject Waterkoker;
    public GameObject Vorkheftruck;
    public GameObject Koffietas;
    public GameObject Keuken;
    public GameObject Toilet;
    public GameObject Lasagne;
    public GameObject Gieter;
    public GameObject Kapiteinshoed;
    public GameObject TV;
    public GameObject Roomba;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) == true)
        {
            Object += 1;
            Debug.Log(Object);

        }

        if (Object > 10)
        {
            Object = 0;
            Debug.Log(Object);
        }

        Select();

    }

    private void Select()
    {
        if (Object == 1)
        {
            Waterkoker.SetActive(true);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 2)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(true);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 3)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(true);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 4)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(true);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 5)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(true);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 6)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(true);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 7)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(true);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 8)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(true);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }

        if (Object == 9)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(true);
            Roomba.SetActive(false);
        }

        if (Object == 10)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(true);
        }

        if (Object == 0)
        {
            Waterkoker.SetActive(false);
            Vorkheftruck.SetActive(false);
            Koffietas.SetActive(false);
            Keuken.SetActive(false);
            Toilet.SetActive(false);
            Lasagne.SetActive(false);
            Gieter.SetActive(false);
            Kapiteinshoed.SetActive(false);
            TV.SetActive(false);
            Roomba.SetActive(false);
        }
    }

}
