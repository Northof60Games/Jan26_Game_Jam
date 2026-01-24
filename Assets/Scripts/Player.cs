using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    // Initial variables
    [SerializeField] private float thrust= 5f;
    [SerializeField] private float turnSpeed = 180f;
    [SerializeField] private float maxSpeed = 15f;

    private float linearDragWhileThrusting = 0.3f;
    private float linearDragNotThrusting = 0f;
    
    private Rigidbody2D rb;
    private float moveInput;
    private float turnInput;

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
}
