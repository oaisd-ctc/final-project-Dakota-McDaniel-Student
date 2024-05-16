using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;
    [SerializeField] private GameObject[] noteInstances;
    private int numberOfInstances = 15;
    private int instanceIndex;
    [SerializeField] private GameObject playerHit;
    AudioSource audioSource;
    bool CrIsRunning = false;
    Fade fade;
    // Start is called before the first frame update
    void Start()
    {
        fade = FindFirstObjectByType<Fade>();
        audioSource = FindFirstObjectByType<AudioSource>();
        noteInstances = new GameObject[numberOfInstances];
        for (int i = 0; i < numberOfInstances; i++)
        {
            noteInstances[i] = Instantiate(notePrefab, transform.position, Quaternion.identity);
            noteInstances[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (audioSource.time > 0 && CrIsRunning == false)
        {
            print("Start");
            StartCoroutine(SpawnNotesCoroutine());
        }

    }


    void Spawnnote()
    {
        noteInstances[instanceIndex].SetActive(true);
        noteInstances[instanceIndex].transform.position = transform.position;
        
        instanceIndex++;
        if (instanceIndex == numberOfInstances) instanceIndex = 0;
    }

    IEnumerator SpawnNotesCoroutine()
    {
        //There is a better way to do this, didn't have time
        CrIsRunning = true;
        yield return new WaitForSeconds(.6f);
        Spawnnote();

        yield return new WaitForSeconds(.72f);
        Spawnnote();

        yield return new WaitForSeconds(.72f);
        Spawnnote();

        yield return new WaitForSeconds(.72f);
        Spawnnote();

        yield return new WaitForSeconds(1.30f);
        Spawnnote();

        yield return new WaitForSeconds(.2f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.8f);
        Spawnnote();

        yield return new WaitForSeconds(.8f);
        Spawnnote();

        yield return new WaitForSeconds(.8f);
        Spawnnote();

        yield return new WaitForSeconds(1.15f);
        Spawnnote();

        yield return new WaitForSeconds(.2f);
        Spawnnote();

        yield return new WaitForSeconds(.8f);
        Spawnnote();

        yield return new WaitForSeconds(.8f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.825f);
        Spawnnote();

        yield return new WaitForSeconds(.375f);
        Spawnnote();

        yield return new WaitForSeconds(.375f);
        Spawnnote();

        yield return new WaitForSeconds(.375f);
        Spawnnote();

        yield return new WaitForSeconds(.375f);
        Spawnnote();

        yield return new WaitForSeconds(.375f);
        Spawnnote();

        yield return new WaitForSeconds(2.5f);
        fade.FadeOut();

    }


}
