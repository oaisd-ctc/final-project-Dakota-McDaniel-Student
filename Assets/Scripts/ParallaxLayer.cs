using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public class Parallax
    {
        public static float speed = 2f;
        public enum Layer
        {
            Note
        }

        public static float GetSpeed(Layer layer)
        {
            switch (layer)
            {
                default:
                    return speed * 2.1f;
            }
        }
    }
    public Transform[] tiles;
    public float left = -19f;
    public Vector3 right = new Vector3(19f, 0f, 0f);

    public Parallax.Layer layer;


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.GetSpeed(layer);
        }
    }
}
