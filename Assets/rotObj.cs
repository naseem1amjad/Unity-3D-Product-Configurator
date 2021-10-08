using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    float rotSpeed = 20;

    public float xSpeed = 2f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY);

    }


    void Update()
    {
        transform.Rotate(
             xSpeed * Time.deltaTime,
             ySpeed * Time.deltaTime,
             zSpeed * Time.deltaTime
        );
    }
}
