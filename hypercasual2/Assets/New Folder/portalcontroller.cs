using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcontroller : MonoBehaviour
{
    public float speed = 1f;
    void FixedUpdate()
    {
        Vector3 a = new Vector3(transform.position.x, transform.position.y, 2.22f);
        Vector3 b = new Vector3(transform.position.x, transform.position.y, -2.22f);
        transform.position = Vector3.Lerp(a, b, Mathf.PingPong(Time.time, speed));
    }
}
