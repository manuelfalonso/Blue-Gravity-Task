using UnityEngine;
using UnityEngine.Events;

public class InteractionHandler : MonoBehaviour
{
    [Header("Events")]
    public UnityEvent OnInteraction = new UnityEvent();


    public void HandleInteracion()
    {
        OnInteraction?.Invoke();
        Debug.Log($"Open Cloth Shop");
    }
}
