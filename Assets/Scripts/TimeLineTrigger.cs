using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger : MonoBehaviour
{

    public PlayableDirector timeLine;
    public bool oneTimeTimeline = true;

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        timeLine.Play();
        if (oneTimeTimeline)
        {
            Destroy(gameObject);
        }
    }
}
