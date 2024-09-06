using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] ModuleManager moduleManager;
    private InputMap input;
    private Vector2 movement; 

    private void Awake()
    {
        input = new InputMap();

        input.Player.Move.performed += OnMove;
        input.Player.Move.Enable();

        input.Player.Interact.performed += OnInteract;
        input.Player.Interact.Enable();
    }

    void FixedUpdate()
    {
        moduleManager.Move(movement);
    }

    private void OnMove(InputAction.CallbackContext obj)
    {
        movement = obj.ReadValue<Vector2>();
    }

    private void OnInteract(InputAction.CallbackContext obj)
    {
        moduleManager.Interact();
    }
}
