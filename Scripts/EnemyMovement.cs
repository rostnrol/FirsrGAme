using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _speed;
    [SerializeField] private WallDetector _wallDetector;

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);

        if (_wallDetector.IsWallHit())
            transform.eulerAngles = new Vector3(0, 180, 0);
        else
            transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
