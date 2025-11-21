using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class ToggleFireworkParticle : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    private ParticleSystem fireworkParticle;
    public ParticleSystem igniteParticle;
    public ParticleSystem extinguishParticle;
    public GameObject pointLight;

    private void Start()
    {
        fireworkParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (fireworkParticle.isPlaying)
            {
                fireworkParticle.Stop();
                pointLight.SetActive(false);
                if (extinguishParticle != null)
                    extinguishParticle.Play();
            }
            else
            {
                fireworkParticle.Play();
                pointLight.SetActive(true);
                if (igniteParticle != null)
                    igniteParticle.Play();
            }
        }
    }
}
