using UnityEngine;
using UnityEngine.UI; 

public class FireworkSizeController : MonoBehaviour
{
    public Slider sizeSlider;
    public ParticleSystem fireworkParticles;

    public void UpdateFireworkSize()
    {
        if (fireworkParticles != null)
        {
            var main = fireworkParticles.main;

            main.startSpeed = sizeSlider.value * 200f;
        }
    }
}