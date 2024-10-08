﻿using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ShootingStar
{
    public class PlayerInputManager:Singleton<PlayerInputManager>,PlayerInput.IGamePlayActions
    {
        public PlayerInput playerInput;

        public Action<Vector2> onMove;
        public Action onStopMove;
        public Action onFire;
        public Action onStopFire;

        public void OnInit()
        {
            playerInput = new PlayerInput();
            playerInput.GamePlay.SetCallbacks(this);
        }

        public void OnEnable()
        {
            playerInput.Enable();
        }

        public void OnDisable()
        {
            playerInput.Disable();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                onMove(context.ReadValue<Vector2>());
            }

            if (context.canceled)
            {
                onStopMove();
            }
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                onFire();
            }
            if (context.canceled)
            {
                onStopFire();
            }
        }
    }
}