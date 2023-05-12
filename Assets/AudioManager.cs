using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private Sound[] sounds;

    private static AudioManager instance;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.setAudioSource(gameObject.AddComponent<AudioSource>());

            s.getAudioSource().clip = s.getAudioClip();
            s.getAudioSource().volume = s.getVolume();
            s.getAudioSource().pitch = s.getPitch();
            s.getAudioSource().loop = s.isLooped();
        }
    }

    public void play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.getName() == name);

        if (s == null)
        {
            Debug.Log("Sound not found!!!");
            return;
        }

        s.getAudioSource().Play();
    }
}
