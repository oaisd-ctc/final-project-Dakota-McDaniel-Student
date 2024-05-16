using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GameObject note;
    PointTracker pointTracker;
    private bool NotinCollider = true;
    private bool goodHit = false;
    private int goodNotes;

    // Start is called before the first frame update
    void Start()
    {
        pointTracker = FindFirstObjectByType<PointTracker>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && NotinCollider == true)
        {
            BadNotePress();
        }
        if (Input.GetKeyDown(KeyCode.Space) && NotinCollider == false)
        {
            HitInCollider();
        }
    }

    //Try using tags
    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("Trigger");
        NotinCollider = false;
    }

    private void BadNotePress()
    {
        pointTracker.SubtractPoints();
        print("BadNotePress");
    }

    private void HitInCollider()
    {
        //print("GoodNote");
        goodNotes++;
        note.SetActive(false);
        pointTracker.AddPoints();
        NotinCollider = true;
        goodHit = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //print("Exit");
        if (goodHit == false)
        {
            print("Missed Note");
            pointTracker.SubtractPoints();
        }
        NotinCollider = true;
        goodHit = false;
    }
}