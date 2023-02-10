using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateRotate : MonoBehaviour
{
    public float translatespeed = 1;
    public float rotatespeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(translatespeed * Vector3.up * Time.deltaTime, Space.World);
        gameObject.transform.Rotate(0, rotatespeed, 0);
    }
}
