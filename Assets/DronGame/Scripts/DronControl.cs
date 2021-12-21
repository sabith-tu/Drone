using UnityEngine;
using UnityEngine.InputSystem;

public class DronControl : MonoBehaviour
{

    DronInputs inp;
    Rigidbody rb;

    //Quaternion lerpStart;
    Quaternion lerpEnd;


    [Space(20)]
    [Header("Speed of the Drone : ")]
    [Range(1,10)] public float speedXZ;
    [Range(1,10)] public float speedY;

    [Space(20)]
    [Header("Rotation of the Drone when moving : ")]
    [Range (0.01f , 1f)] public float angleLearpSpeed;
    [Range (1f , 100f)] public float angleLearpMaxValue;


    private void FixedUpdate() {
        
        movment();

        RotationTowardMovingDirection();

    }

    void RotationTowardMovingDirection()
    {

        lerpEnd = Quaternion.Euler( MoveXZ().y * angleLearpMaxValue , 0f , MoveXZ().x * angleLearpMaxValue *-1f );

        rb.rotation = Quaternion.Lerp( this.transform.rotation , lerpEnd , angleLearpSpeed);
    }

    void movment()
    {
        rb.velocity = new Vector3(MoveXZ().x*speedXZ , MoveY()*speedY , MoveXZ().y*speedXZ);
    }

    private void Awake() 
    {
        //inp.Dron.Movement.performed += ctx => movement();
        inp = new DronInputs();
        rb = this.GetComponent<Rigidbody>();
    }

    Vector2 MoveXZ()
    {
        return inp.Dron.Movement.ReadValue<Vector2>();
    }

    float MoveY()
    {
        return 0f; //inp.Dron.UpDown.ReadValue<float>();
    }

    private void OnEnable() 
    {
        inp.Enable();
    }

    private void OnDisable() 
    {
        inp.Disable();
    }

}