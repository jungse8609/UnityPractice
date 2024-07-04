using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brokable : MonoBehaviour
{
    [SerializeField] private int count = 3;
    private bool isBroken = false;

    private Collider collider;

    private void Start()
    {
        collider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isBroken) return;

        if (collision.gameObject.CompareTag("Light"))
        {
            count -= 1;
            if (count <= 0)
            {
                isBroken = true;
                OnBroken();
            }
        }
    }

    private void OnBroken()
    {
        collider.enabled = false;

        // Animation, Sprite
    }
}
