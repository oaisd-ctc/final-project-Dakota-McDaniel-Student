using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradeUI : MonoBehaviour
{
    public PointTracker tracker;
    public Text gradeText;
    int finalPoints;
    Fade fade;
    bool failed;
    // Start is called before the first frame update
    void Start()
    {
        tracker = FindFirstObjectByType<PointTracker>();
        finalPoints = tracker.GetPoints();
        fade = FindFirstObjectByType<Fade>();
        failed = fade.GetBoolFailed();
        if (failed == true || finalPoints < 1500)
        {
            gradeText.text = "Failed :(";
        }
        else if (finalPoints == 4000)
        {
            gradeText.text = "Perfect!";
        }
        else if (finalPoints > 3500)
        {
            gradeText.text = "Grade: S";
        }
        else if(finalPoints > 3000)
        {
            gradeText.text = "Grade: A";
        }
        else if(finalPoints > 2500)
        {
            gradeText.text = "Grade: B";
        }
        else if(finalPoints > 2000)
        {
            gradeText.text = "Grade: C";
        }
        else if (finalPoints > 1500)
        {
            gradeText.text = "Grade: D";
        }
    }

    private void OnDestroy()
    {
        tracker.ResetPoints();
    }
}
