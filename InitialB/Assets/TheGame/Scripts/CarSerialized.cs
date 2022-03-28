using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TheGame.Scripts.Car
{
    [CreateAssetMenu(menuName = "InitialB/Car/Car Settings")]
    public class CarSerialized : ScriptableObject
    {
        [SerializeField] private float _moveSpeed;

        public float MoveSpeed
        {
            get { return _moveSpeed; }
            set { _moveSpeed = value; }
        }
        [SerializeField] private float _maxSpeed;

        public float MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        [SerializeField] private float _drag;

        public float Drag
        {
            get { return _drag; }
            set { _drag = value; }
        }

        [SerializeField] private float _steerAngle;

        public float SteerAngle
        {
            get { return _steerAngle; }
            set { _steerAngle = value; }
        }
        [SerializeField] private float _traction;

        public float Traction
        {
            get { return _traction; }
            set { _traction = value; }
        }

    }
}