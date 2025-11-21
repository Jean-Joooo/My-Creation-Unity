using UnityEngine;

public class SkySwapper : MonoBehaviour
{
    public Material daySkyboxMaterial;
    public Material nightSkyboxMaterial;
    public Light sunDirectionalLight; 

    [Header("Day/Night Settings")]
    public Color dayAmbientColor = Color.white;
    public Color nightAmbientColor = new Color(0.1f, 0.15f, 0.3f); 

    public void SetDay()
    {
        RenderSettings.skybox = daySkyboxMaterial;

        sunDirectionalLight.intensity = 2.9f; 
        RenderSettings.ambientLight = dayAmbientColor;
    }

    public void SetNight()
    {
        RenderSettings.skybox = nightSkyboxMaterial;

        sunDirectionalLight.intensity = 0.8f; 
        RenderSettings.ambientLight = nightAmbientColor;
    }
}