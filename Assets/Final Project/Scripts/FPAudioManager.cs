using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPAudioManager : MonoBehaviour
{
    public AudioSource drinkSFX;
    public AudioSource iceSFX;
    public AudioSource clickSFX;
    public AudioSource serveSFX;
    // Start is called before the first frame update
    public void PlayAudio(string audioName)
    {
        switch (audioName.ToLower())
        {
            case "drink":
                {
                    drinkSFX.Play();
                    break;
                }
            case "ice":
                {
                    iceSFX.Play();
                    break;
                }
            case "serve":
                {
                    serveSFX.Play(); 
                    break;
                }
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickSFX.Play();
        }
    }

    public void Stop()
    {
        drinkSFX.Stop();
    }
}
