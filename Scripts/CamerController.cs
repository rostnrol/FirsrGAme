using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private float _leftLimit;
    [SerializeField] private float _rightLimit;
    [SerializeField] private float _upLimit;
    [SerializeField] private float _downLimit;

    private void FollowPlayer()
    {
        var heroPosition = new Vector3 (_hero.transform.position.x, _hero.transform.position.y, -10);
        transform.position = heroPosition;
    }

    private void CameraLimit()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, _leftLimit, _rightLimit), Mathf.Clamp(transform.position.y, _downLimit, _upLimit), -10);
    }

    void Update()
    {
        FollowPlayer();
        CameraLimit();
    }
}
