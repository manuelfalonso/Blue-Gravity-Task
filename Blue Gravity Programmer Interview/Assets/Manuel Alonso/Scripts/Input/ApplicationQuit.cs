using UnityEngine;
using UnityEngine.InputSystem;

public class ApplicationQuit : MonoBehaviour
{
    public void OnQuit(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        Application.Quit();
    }
}
