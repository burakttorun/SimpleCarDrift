using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheGame.Scripts.InputManager
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private InputSetting _setting;
        // Update is called once per frame
        void Update()
        {
            _setting.Horizontal = Input.GetAxis("Horizontal");
            _setting.Vertical = Input.GetAxis("Vertical");

        }
    }
}
