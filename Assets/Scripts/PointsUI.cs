using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour
{
    int points = 000;
    public PointTracker tracker;
    public Text pointsDisplay;
    public int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        tracker = FindFirstObjectByType<PointTracker>();
        points = tracker.GetPoints();
        //highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    //private void OnDestroy()
    //{
    //PlayerPrefs.SetInt("HighScore", 0);
    //PlayerPrefs.Save();
    //}

    // Update is called once per frame
    void Update()
    {

        points = tracker.GetPoints();

        pointsDisplay.text = "Points: " + points.ToString();

        //if (points > highScore) highScore = points;

    }
}
