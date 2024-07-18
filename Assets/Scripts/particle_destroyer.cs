using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_destroyer : MonoBehaviour
{
    public ParticleSystem particleSystem;
    void Start()
    {
        float duration_particle = particleSystem.main.duration;
        float maxStartLifetime = particleSystem.main.startLifetime.constantMax;
        float total_duration = duration_particle + maxStartLifetime;
        Destroy(gameObject, total_duration);
    }
}
