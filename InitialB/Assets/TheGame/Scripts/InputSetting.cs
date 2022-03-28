using UnityEngine;

namespace TheGame.Scripts.InputManager
{
    [CreateAssetMenu(menuName = "InitialB/Input/Input Settings")]
    public class InputSetting : ScriptableObject
    {
        [Header("Horizontal")]
        [SerializeField] private float _horizontal;
        public float Horizontal
        {
            get { return _horizontal; }
            set { _horizontal = value; }
        }

        [Header("Vertical")]
        [SerializeField] private float _vertical;
        public float Vertical
        {
            get { return _vertical; }
            set { _vertical = value; }
        }

    }
}