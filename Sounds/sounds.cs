using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour {
    
    public AudioSource myAudioSource1;
    public AudioSource myAudioSource2;
    public AudioSource myAudioSource3;



    void Start()
    {
        // at start, get the Renderer component of this object
        // and set it to rend

        // and audio source
      
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            // make sure its not already playin
            if (myAudioSource1.isPlaying == false)
            {
                myAudioSource1.Play();
                myAudioSource2.Stop();
                myAudioSource3.Stop();

            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            // make sure its not already playin
            if (myAudioSource2.isPlaying == false)
            {
                myAudioSource1.Stop();
                myAudioSource2.Play();
                myAudioSource3.Stop();


            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            // make sure its not already playin
            if (myAudioSource3.isPlaying == false)
            {
                myAudioSource1.Stop();
                myAudioSource2.Stop();
                myAudioSource3.Play();


            }
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            myAudioSource1.Stop();
            myAudioSource2.Stop();
            myAudioSource3.Stop();


        }
    }
}
