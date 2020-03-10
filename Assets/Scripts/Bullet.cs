using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float MaxLifeSpan = 5f;
    public float LifeSpan = 0;
    private void OnCollisionEnter(Collision collision)
    {

    }

    private void Update()
    {
        LifeSpan += Time.deltaTime;

        if (LifeSpan >= MaxLifeSpan)
        {
            Destroy(gameObject);
        }
    }
}