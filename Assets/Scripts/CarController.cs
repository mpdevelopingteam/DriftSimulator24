using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarController : MonoBehaviour
{
    public enum Axel
    {
        Front, 
        Rear
    }

    [System.Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel; 
    }

    public float maxAcceleration = 100.0f;
    public float brakeAcceleration = 1000.0f;

    public float turnSensitivity = 1.0f;
    public float maxSteerAngle = 30.0f;

    public List<Wheel> wheels;

    float moveInput;
    float steerInput;

    private Rigidbody carRB;

    void Start(){
        carRB = GetComponent<Rigidbody>();        
    }

    void Update(){
        GetInputs();
        AnimateWheels();
    }

    void LateUpdate(){
        Move();
        Steer();
    }

    void GetInputs(){
        moveInput = Input.GetAxis("Vertical");
        steerInput = Input.GetAxis("Horizontal");
    }

    void Move(){
        foreach(var wheel in wheels){
            wheel.wheelCollider.motorTorque = moveInput * 600 *  maxAcceleration * Time.deltaTime;
        }
    }

    void Steer(){
        foreach(var wheel in wheels){
            if(wheel.axel == Axel.Front){
                var _steerAngle = steerInput * turnSensitivity * maxSteerAngle ;
                wheel.wheelCollider.steerAngle = Mathf.Lerp(wheel.wheelCollider.steerAngle,_steerAngle,0.6f);
            }
        }
    }

    void AnimateWheels(){
        foreach(var wheel in wheels){
            Quaternion rot;
            Vector3 pos;
            wheel.wheelCollider.GetWorldPose(out pos, out rot);
            wheel.wheelModel.transform.position = pos;
            wheel.wheelModel.transform.rotation = rot;
        }

    }

}
