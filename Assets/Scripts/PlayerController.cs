using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ShadowChimera
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputActionAsset m_inputActionAsset;
        [SerializeField] private CharacterController m_characterController;
        [SerializeField] private speedMove = 5;

        public InputAction moveAction;

        private InputActionMap m_playerMap;
        private InputAction m_moveAction;

        private void Awake()
        {
            m_playerMap = m_inputActionAsset.FindActionMap("Player");
            InputAction moveAction = m_playerMap.FindAction("Move");

            var move = moveAction.ReadValue<Vector2>();
        }

        private void OnEnable()
        {
            m_playerMap.Enable();
        }

        private void OnDisable()
        {
            m_playerMap.Disable();
        }

        private void Update()
        {
         var move = m_moveAction.ReadValue<Vector2>();
        if (move != Vector2.zero) 
            {
                Debug.Log(move);
                Vector3 dir = new Vector3(move.x, 0f, move.y);
                m_characterController.SimpleMove(move = move_speedMove);
            }
        }
    }
}
