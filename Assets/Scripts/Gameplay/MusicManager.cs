using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioSource audioSource;

    public void Init()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
    }
    
    public void PlayMusic(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
