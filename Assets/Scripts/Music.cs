using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Music : MonoBehaviour
{
    private int points;
    AudioSource audioSource;
    PointTracker pointTracker;
    Fade fade;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindFirstObjectByType<AudioSource>();
        pointTracker = FindFirstObjectByType<PointTracker>();
        audioSource.PlayDelayed(2);
        fade = FindFirstObjectByType<Fade>();
    }

    private void Update()
    {

    }

    public void PrintTime()
    {
        print(audioSource.time);
    }


}
