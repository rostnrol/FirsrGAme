using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Animator _walking;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private GroundChecker _groundChecker;

    private bool _facedRight = true;

    private void Update()
    {
        _walking.enabled = false;

        if (Input.GetKey(KeyCode.D))
        {
            _walking.enabled = true;
            transform.Translate(_speed * Time.deltaTime, 0, 0);

            if (_facedRight == false)
                Flip();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _walking.enabled = true;
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);

            if (_facedRight == true)
                Flip();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (_groundChecker.IsGroundHit())
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpForce); 
        }    
    }

    private void Flip()
    {
        _facedRight = !_facedRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
