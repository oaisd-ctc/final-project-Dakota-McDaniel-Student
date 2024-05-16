using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    private void Awake()
    {

        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    public void TitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void SongOne()
    {
        SceneManager.LoadScene(2);
    }

    public void EndScreen()
    { SceneManager.LoadScene(3);}

    private void OnDestroy()
    {
        DontDestroyOnLoad(this);
    }

}
