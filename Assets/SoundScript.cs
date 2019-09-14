using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioClip soundClip;
    public AudioSource soundSource;
    public GameObject bird;
    public float counter;

    // Start is called before the first frame update
    void Start()
    {
        soundSource.clip = soundClip;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (bird. == true)
        //{

            counter += Time.deltaTime;
            bool currentlyPlaying = false;
            if (counter > 10 && counter < 11 && currentlyPlaying == false)
            {
                //soundSource.PlayOneShot(soundClip);
                counter = 0;
                currentlyPlaying = true;
            }
            if (counter > 2 && currentlyPlaying == true)
            {
                currentlyPlaying = false;
            }
        //}
    }
}
