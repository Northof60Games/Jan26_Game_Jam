using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    // Initial variables
    [SerializeField] private float thrust = 8f;
    [SerializeField] private float turnSpeed = 180f;
    [SerializeField] private float maxSpeed = 15f;

    private float linearDragWhileThrusting = 0.3f;
    private float linearDragNotThrusting = 0f;
    
    private Rigidbody2D rb;
    // TODO Add the control system & ChatGPT move methods
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Keyboard.current.upArrowKey.isPressed ||Keyboard.current.wKey.isPressed)
        {
            rb.AddForce(transform.up * thrust, ForceMode2D.Force);
            
        }

        if (Keyboard.current.leftArrowKey.isPressed ||Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(turnSpeed, ForceMode2D.Force );
            
        }

        if (Keyboard.current.rightArrowKey.isPressed ||Keyboard.current.sKey.isPressed)
        {
            rb.AddTorque(-turnSpeed, ForceMode2D.Force);
            
            
            
        }
    }
}
