using UnityEngine;
using UnityEngine.InputSystem;

public class ApplicationQuit : MonoBehaviour
{
    // Called from Input interaction
    public void OnQuit(InputAction.CallbackContext context)
    {
        Debug.Log($"1");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
		Application.Quit();
#endif
    }
}
