using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource soundEffectsSourse;

    public AudioClip jumpSound;
    public AudioClip backgroundMusic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void PlaySoundEffect(AudioClip clip)
    {
        soundEffectsSourse.PlayOneShot(clip);
    }
}
