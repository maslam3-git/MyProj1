using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    void Awake()
    {
        musicSource.Play();
    }
}
