using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class Fade : MonoBehaviour
{
    [SerializeField] private CanvasGroup fadingCanvasGroup;
    PointTracker pointTracker;
    int points = 0;
    AudioSource audioSource;
    GameManager gameManager;
    private bool isFaded = false;
    public bool failed = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindFirstObjectByType<AudioSource>();
        pointTracker = FindFirstObjectByType<PointTracker>();
        gameManager = FindAnyObjectByType<GameManager>();
        failed = pointTracker.GetBoolFailed();
    }


    // Update is called once per frame
    void Update()
    {
        points = pointTracker.GetPoints();
        if (points < -100)
        {
            failed = true;
            FadeOut();
        }
    }

    public void FadeOut()
    {
        
        if (isFaded)
        {
            fadingCanvasGroup.DOFade(1, 2);
            isFaded = true;
        }
        else
        {
            fadingCanvasGroup.DOFade(2, 4);
            Invoke("CallEndScreen", 1.5f);
        }
        StartCoroutine(StartAudioFade(audioSource, 1.5f, 0f));
        
    }

    void CallEndScreen()
    {
        gameManager.EndScreen();
    }

    public bool GetBoolFailed()
    {
        return failed;
    }

    IEnumerator StartAudioFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }


}