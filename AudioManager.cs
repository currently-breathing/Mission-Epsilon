using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
   
    public static AudioManager Instance;

   public Sound[] musicSounds, sfxSounds;
   public AudioSource musicSource, sfxSource;

   private string currentScene;



    private void Awake()
    {

        currentScene = SceneManager.GetActiveScene().name;
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(string name)
    {
            Sound s = Array.Find(musicSounds, x => x.name == name);

            if (s == null)
            {
                Debug.Log("Sound not found");
            }
            else
            {
                musicSource.clip = s.clip;
                musicSource.Play();
            }

    }

    void Start()
    {
        if(currentScene == "Gameplay Scene (Space Level)")
        {
            PlayMusic("Ephemeral");
        }
        else if (currentScene == "Gameplay Scene (Platform)")
        {
            PlayMusic("Silent Homes");

        }
        else if (currentScene == "Gameplay Scene (Ground Level)")
        {
            PlayMusic("Believe");

        }
    }

    void Update()
    {
        var currentScene = SceneManager.GetActiveScene().name;


    }

    public void PlaySFX(string name)
    {
            Sound s = Array.Find(sfxSounds, x => x.name == name);

            if (s == null)
            {
                Debug.Log("SFX not found");
            }
            else
            {
                sfxSource.PlayOneShot(s.clip);
            }
    }

}
