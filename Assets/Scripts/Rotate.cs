using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2D : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public bool randomizeSpeed = true;
    public float minSpeed = 10f;
    public float maxSpeed = 100f;

    private void Start()
    {
        if (randomizeSpeed)
        {
            rotationSpeed = Random.Range(minSpeed, maxSpeed);
        }
    }

    private void Update()
    {
        // Rotation um die Z-Achse (2D-Ebene)
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
