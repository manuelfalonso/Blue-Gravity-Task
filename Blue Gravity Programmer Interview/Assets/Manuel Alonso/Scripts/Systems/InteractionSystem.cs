using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class InteractionSystem : MonoBehaviour
{
    [Header("Config")]
    [SerializeField]
    private Collider2D _interactionTrigger = default(Collider2D);
    [SerializeField]
    private ContactFilter2D _contactFilter = default(ContactFilter2D);

    [Header("Events")]
    public UnityEvent OnDefaultInteraction = new UnityEvent();

    private List<Collider2D> _contacts = new List<Collider2D>();


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

        //if (contactsQuantity > 0 && _shopUI.activeSelf)
        //{
        //    _inventoryUI.SetActive(true);
        //    //_contacts[0].GetComponent<InteractionHandler>().HandleInteracion();
        //}
        //else
        //    //OnDefaultInteraction?.Invoke();
        //    _inventoryUI.SetActive(!_inventoryUI.activeSelf);
    }
}
