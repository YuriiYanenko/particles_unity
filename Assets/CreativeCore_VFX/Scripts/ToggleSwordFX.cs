using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwordFX : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    public ParticleSystem FX_Particle;
    public ParticleSystem startParticle;
    public ParticleSystem extinguishParticle;
    public GameObject pointLight;

    bool isPlaying = true;

    private void Start()
    {
        //FX_Particle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if(isPlaying)
            {
                FX_Particle.Stop();
                pointLight.SetActive(false);
                if (extinguishParticle != null)
                    extinguishParticle.Play();
                isPlaying = false;
            } 
            else
            {
                FX_Particle.Play();
                pointLight.SetActive(true);
                if (startParticle != null)
                    startParticle.Play();
                isPlaying = true;
            }
        }
    }
}
