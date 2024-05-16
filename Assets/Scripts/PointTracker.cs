using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracker : MonoBehaviour
{
    private bool failed = false;
    [SerializeField] private int points = 0;
    
    public static PointTracker oldInstance;

    private void Awake()
    {

        if (oldInstance)
        {
            Destroy(this);
        }
        else
        {
            oldInstance = this;
        }

        points = 0;

    }

    private void OnEnable()
    {
        points = 0;
    }

    public int GetPoints()
    {
        return points;
    }

    public int AddPoints()
    {
        points = points + 100;
        return points;
    }

    public int SubtractPoints()
    {
        points -= 50;
        return points;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void OnDestroy()
    {
        GetBoolFailed();
    }

    public bool GetBoolFailed()
    {
        return failed;
    }

    public int ResetPoints()
    {
        return points = 0;
    }


}