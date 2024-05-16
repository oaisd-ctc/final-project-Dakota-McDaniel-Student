using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ParallaxLayer;

public class Note : MonoBehaviour
{
    public Parallax.Layer layer;
    public float endRange = -10f;

    void Update()
    {

        transform.position += Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime;

        if (transform.position.x <= endRange)
        {
            gameObject.SetActive(false);
        }
    }
}
