using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class InteractionSystem : MonoBehaviour
{
    [SerializeField]
    private Collider2D _interactionTrigger = default(Collider2D);
    [SerializeField]
    private ContactFilter2D _contactFilter = default(ContactFilter2D);

    private List<Collider2D> _contacts = new List<Collider2D>();

    [Header("Events")]
    public UnityEvent OnDefaultInteraction = new UnityEvent();


    // Called from Input interaction
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (_interactionTrigger == null) return;
        if (!context.performed) return;
        var contactsQuantity = _interactionTrigger.OverlapCollider(_contactFilter, _contacts);

        if (contactsQuantity > 0)
            _contacts[0].GetComponent<InteractionHandler>().HandleInteracion();
        else
            OnDefaultInteraction?.Invoke();
    }
}
