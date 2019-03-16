using UnityEngine.Audio;
using System;
using UnityEngine;

//script de brakeys video : (Introduction to audio in uniyt)

public class audioManager : MonoBehaviour
{
    public sound[] sounds;


    // Start is called before the first frame update
    void Awake()
    {

        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}
