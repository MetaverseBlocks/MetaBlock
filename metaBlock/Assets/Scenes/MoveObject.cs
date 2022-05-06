using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 30f;
    Vector3 fb = new Vector3(0, 0, 1);
    Vector3 lr = new Vector3(0, 1, 0);

    void Update()
    {
        float v = Input.GetAxis("Vertical") * Time.deltaTime;
        float h = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(fb * v * speed);
        transform.Rotate(lr * h * speed);
    }
}