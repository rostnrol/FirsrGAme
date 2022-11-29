using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    private bool _isWallHit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_isWallHit)
            _isWallHit = false;
        else
            _isWallHit = true;
    }

    public bool IsWallHit() => _isWallHit;
}
