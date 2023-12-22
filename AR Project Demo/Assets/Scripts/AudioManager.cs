using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;
    void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (var s in sounds) 
        {
          s.source =  gameObject.AddComponent<AudioSource>();

          s.source.clip = s.clip;
          s.source.volume = s.volume;
          s.source.pitch = s.pitch;
          s.source.loop = s.loop;

          s.source.outputAudioMixerGroup = s.MixerGroup;
        }
    }

    
   public void Play(string clipName)
   {
        Sound s = Array.Find(sounds, sound => sound.name == clipName);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + clipName + " not found!");
            return;
        }
        s.source.Play();
   }
   
   public void Stop(string clipName)  
   {
       Sound s = Array.Find(sounds, sound => sound.name == clipName);
       if (s == null)
       {
           Debug.LogWarning("Sound: " + clipName + " not found!");
           return;
       }
       s.source.Stop();
   }

   public void Pause(string clipName)  
   {
       Sound s = Array.Find(sounds, sound => sound.name == clipName);
       if (s == null)
       {
           Debug.LogWarning("Sound: " + clipName + " not found!");
           return;
       }
       s.source.Pause();
   }
   public void UnPause(string clipName)  
   {
       Sound s = Array.Find(sounds, sound => sound.name == clipName);
       if (s == null)
       {
           Debug.LogWarning("Sound: " + clipName + " not found!");
           return;
       }
       s.source.UnPause();
   }


   private void Start()
   {
     
   }
}
