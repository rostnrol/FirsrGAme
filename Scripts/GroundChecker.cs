using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    private bool _isGroundHit;

    public bool IsGroundHit() => _isGroundHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isGroundHit = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGroundHit = false;
    }
}
