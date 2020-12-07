using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Vector2 inputVector;
    public static readonly float CURSOR_SPEED = 2;

    void Update()
    {
        transform.position += new Vector3(inputVector.x, inputVector.y) * CURSOR_SPEED;
    }
}
