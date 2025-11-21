using UnityEngine;
using UnityTemplateProjects;

public class MenuTargetSetter : MonoBehaviour
{
    public SimpleCameraController cameraController;

    private float m_SavedPitch;
    private float m_SavedYaw;

    private const float MenuPitch = 25f;
    private const float MenuYaw = 20f;

    public void GoToMenuRotation()
    {
        if (cameraController != null)
        {

            m_SavedPitch = cameraController.GetTargetPitch();
            m_SavedYaw = cameraController.GetTargetYaw();

            cameraController.SetTargetRotation(MenuPitch, MenuYaw);
        }
    }

    public void GoToDefaultRotation()
    {
        if (cameraController != null)
        {
            cameraController.SetTargetRotation(m_SavedPitch, m_SavedYaw);
        }
    }
}