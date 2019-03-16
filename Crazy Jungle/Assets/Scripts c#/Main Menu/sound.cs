using UnityEngine.Audio;
using UnityEngine;


//script de brakeys video : (Introduction to audio in uniyt)

[System.Serializable]
public class sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
