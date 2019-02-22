using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    AudioSource[] sounds;
    AudioSource myAudioSource1;
    AudioSource myAudioSource2;
    AudioSource myAudioSource3;


    void Start()
    {
        // at start, get the Renderer component of this object
        // and set it to rend

        // and audio source
        sounds = GetComponents<AudioSource>();
        myAudioSource1 = sounds[0];
        myAudioSource2 = sounds[1];
        myAudioSource3 = sounds[2];

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            // make sure its not already playin
            if (sounds[0].isPlaying == false)
            {
                sounds[0].Play();
                sounds[1].Stop();
                sounds[2].Stop();

            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                // make sure its not already playin
                if (sounds[1].isPlaying == false)
                {
                    sounds[0].Stop();
                    sounds[1].Play();
                    sounds[2].Stop();


                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    // make sure its not already playin
                    if (sounds[2].isPlaying == false)
                    {
                        sounds[0].Stop();
                        sounds[1].Stop();
                        sounds[2].Play();


                    }
                    if (Input.GetKeyUp(KeyCode.R))
                    {
                        gameObject.GetComponent<Renderer>().material.color = Color.white;
                        sounds[0].Stop();
                        sounds[1].Stop();
                        sounds[2].Stop();


                    }
                }
            }
        }
    }
}
