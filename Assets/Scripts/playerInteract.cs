using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerInteract : MonoBehaviour
{
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Enable();
        controls.Interact.Interact.performed += Interact;

    }

    private void OnDisable()
    {
        controls.Disable();

        controls.Interact.Interact.performed -= Interact;
    }

    void Start()
    {

        controls.Interact.Interact.performed += Interact;

        controls.Interact.Interact.performed -= Interact;

    }

    public void Interact(InputAction.CallbackContext context)
    {
        context.ReadValueAsButton();
    }

    private void Update()
    {
       float interact = controls.Interact.Interact.ReadValue<float>();
    }
}
