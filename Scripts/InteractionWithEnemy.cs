using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Hero _hero;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
        {
            Vector2 enemyPosition = collision.gameObject.transform.localPosition;
            Vector2 heroPosition = _hero.gameObject.transform.localPosition;
            Vector2 deltaPosition = enemyPosition - heroPosition;

                if (Mathf.Abs(deltaPosition.y) > Mathf.Abs(deltaPosition.x) && heroPosition.y > enemyPosition.y)
                    Destroy(collision.gameObject);
                else
                    Destroy(gameObject);
        }
    }
}
