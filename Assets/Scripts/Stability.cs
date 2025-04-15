using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stability : MonoBehaviour
{
    public float smoothSpeed = 2f;

    void Update()
    {
        Vector3 currentEuler = transform.eulerAngles;
        float newZ = Mathf.LerpAngle(currentEuler.z, 0f, Time.deltaTime * smoothSpeed);
        transform.eulerAngles = new Vector3(currentEuler.x, currentEuler.y, newZ);
    }
}
