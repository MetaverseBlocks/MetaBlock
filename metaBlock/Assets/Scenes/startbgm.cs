using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class startbgm : MonoBehaviour
{
    GameObject Backgroundbgm;
    AudioSource backmusic;
   

    void Awake()
    {
        Backgroundbgm = GameObject.Find("Backgroundbgm");
        backmusic = Backgroundbgm.GetComponent<AudioSource>();
        if (backmusic.isPlaying) return;
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(Backgroundbgm);
        }

    }
    
    public void BackGroundbgmOff()
    {
        Backgroundbgm = GameObject.Find("Backgroudbgm");
        backmusic = Backgroundbgm.GetComponent<AudioSource>();
        if(backmusic.isPlaying) backmusic.Pause();
        
    }

    public void BackGroundbgmOn()
    {
        Backgroundbgm = GameObject.Find("Backgroudbgm");
        backmusic = Backgroundbgm.GetComponent<AudioSource>();
        if(backmusic.isPlaying) return;
        
        
    }
}
