using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClipl;
    // Start is called before the first frame update
    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
