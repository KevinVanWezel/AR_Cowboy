using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineActivator : MonoBehaviour
{
    public PlayableDirector playableDirectorcowboy;
    public PlayableDirector playableDirectorgunman;

    public void playcow()
    {
        playableDirectorcowboy.Play();
    }

    public void playgun()
    {
        playableDirectorgunman.Play();
    }

    private void Update()
    {
      
    }
}
