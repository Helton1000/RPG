using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] Rigidbody2D _rb;
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        _rb.linearVelocity = new Vector2(horizontal, vertical) * _speed;
    }
}