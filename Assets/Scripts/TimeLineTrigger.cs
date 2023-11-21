using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger : MonoBehaviour
{

    public PlayableDirector timeLine;

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        timeLine.Play();
    }

    void Update()
    {
        
    }
}
