using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleNextSound : MonoBehaviour
{

public static bool SoundFlag1 = false;
public AudioClip sound1;
AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad (this);
    }

    // Update is called once per frame
    public void Update()
    {
        if(SoundFlag1 == true)
        audioSource.PlayOneShot(sound1);
        SoundFlag1 = false;
    }
}
