using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public int rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, -rotateSpeed);
    }
}
