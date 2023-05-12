using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    [SerializeField] private string name;

    [SerializeField] private AudioClip sound;

    [SerializeField][Range(0f, 1f)] private float volume;
    [SerializeField][Range(.1f, 3f)] private float pitch;
    [SerializeField] private bool loop;

    private AudioSource source;

    public void setName(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    public void setAudioClip(AudioClip sound)
    {
        this.sound = sound;
    }

    public AudioClip getAudioClip()
    {
        return sound;
    }

    public void setVolume(float volume)
    {
        this.volume = volume;
    }

    public float getVolume()
    {
        return volume;
    }

    public void setPitch(float pitch)
    {
        this.pitch = pitch;
    }

    public float getPitch()
    {
        return pitch;
    }

    public void setLoop(bool loop)
    {
        this.loop = loop;
    }

    public bool isLooped()
    {
        return loop;
    }

    public void setAudioSource(AudioSource source)
    {
        this.source = source;
    }

    public AudioSource getAudioSource()
    {
        return source;
    }
}
