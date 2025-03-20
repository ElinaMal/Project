using UnityEngine;

public class ParticleSystemScript : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    public bool Hurt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hurt)
        {
            ParticleSystem.Play();
        }
        else
        {
            ParticleSystem.Stop();
        }
    }
}
