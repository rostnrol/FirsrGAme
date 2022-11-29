using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireTaker : MonoBehaviour
{
    [SerializeField] private Fire _fire;
    [SerializeField] private Text _fireCounterText;
    private int _firesCount = 0;

    private void Update()
    {
        _fireCounterText.text = "Собрано огоньков " + _firesCount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Fire>(out Fire fire))
        {
            Destroy(fire.gameObject);
            _firesCount++;
            _fireCounterText.text = "Собрано огоньков" + _firesCount;
        }
    }
}
