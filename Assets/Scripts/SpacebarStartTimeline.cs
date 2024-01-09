using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SpacebarStartTimeline : MonoBehaviour
{
    public PlayableDirector director;

    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for a specific condition to start the timeline. Here, we use a simple key press.
        if (Input.GetKeyDown(KeyCode.Space)) // Press Spacebar to play
        {
            Debug.Log("spacy");
            PlayTimeline();
        }
    }

    void PlayTimeline()
    {
       
       director.Play();
       
    }
}
