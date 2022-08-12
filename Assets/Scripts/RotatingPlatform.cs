using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    private Vector3 targetAngles;
    public bool shouldRotate = false;
    public float smooth = 1f;
    float targetAngle = 180;
    public Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        InvokeRepeating("Rotate",3f, 3f);
    }

    private void Update()
    {
        if (shouldRotate)
        {
            float turnSpeed = 8;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, targetAngle), turnSpeed * Time.deltaTime);
        }

    }

    public void Rotate()
    {
        shouldRotate = !shouldRotate;
        targetAngle = Mathf.Abs(rb.rotation) == 180 ? 0f : 180f;
    }
}
