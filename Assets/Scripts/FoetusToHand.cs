using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoetusToHand : MonoBehaviour
{

    public GameObject FoetusTarget;
    public float MoveSpeed = 0.5f;

    public float scale = 1f;
    public float ScaleSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FoetusTarget.transform.position = Vector3.MoveTowards(FoetusTarget.transform.position, transform.position, MoveSpeed * Time.deltaTime);
        
        if (scale > 0.025)
        {
            scale =- ScaleSpeed;
            FoetusTarget.transform.localScale = new Vector3(scale, scale, scale);
        }
        
    }
}
