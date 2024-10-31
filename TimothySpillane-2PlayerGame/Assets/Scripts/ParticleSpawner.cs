using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    [SerializeField] GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnParticle), 0.25f, 0.25f); // spawn a particle every 0.25 seconds
    }
    private void SpawnParticle()
    {
        Instantiate(particle, this.transform.position, this.transform.rotation);// spawn particle on the spawner's position
    }
}
