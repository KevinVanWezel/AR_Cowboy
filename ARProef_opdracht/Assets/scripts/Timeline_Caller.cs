using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_Caller : MonoBehaviour
{
    public PlayableDirector playableDirector;

    public void Play()
    {
        playableDirector.Play();
    }

}
