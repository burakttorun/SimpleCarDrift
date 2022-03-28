using TheGame.Scripts.InputManager;
using UnityEngine;

namespace TheGame.Scripts.Car
{
    public class MovementSystem : MonoBehaviour
    {
        [SerializeField] CarSerialized carSettings;
        [SerializeField] InputSetting inputSetting;
        private Vector3 MoveForce;


        void Update()
        {
            Moving();
            Steering();
            DragAndSpeedLimit();

            Traction();
        }

        private void Traction()
        {
           
            MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, carSettings.Traction * Time.deltaTime) * MoveForce.magnitude;
        }

        private void DragAndSpeedLimit()
        {
            MoveForce *= carSettings.Drag;
            MoveForce = Vector3.ClampMagnitude(MoveForce, carSettings.MaxSpeed);
        }

        private void Steering()
        {
            transform.Rotate(Vector3.up * inputSetting.Horizontal * MoveForce.magnitude * carSettings.SteerAngle * Time.deltaTime);
        }

        private void Moving()
        {
            MoveForce += transform.forward * carSettings.MoveSpeed * Time.deltaTime * inputSetting.Vertical;
            transform.position += MoveForce * Time.deltaTime;
        }
    }
}
