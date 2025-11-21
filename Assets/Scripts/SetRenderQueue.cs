using UnityEngine;

public class SetRenderQueue : MonoBehaviour
{
    public int renderQueue = 3050;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && renderer.material != null)
        {
            renderer.material.renderQueue = renderQueue;
        }
    }
}