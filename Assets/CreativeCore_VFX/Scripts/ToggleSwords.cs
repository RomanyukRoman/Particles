using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ToggleSwords : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;
    public ParticleSystem waterparticle;
    public ParticleSystem fireparticle;

    bool isPlaying = true;
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if(isPlaying)
            {
                waterparticle.Stop();
                fireparticle.Stop();
                isPlaying = false;
            } 
            else
            {
                waterparticle.Play();
                fireparticle.Play();
                isPlaying = true;
            }
        }
    }
}
