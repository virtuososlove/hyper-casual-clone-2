using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fingerscript : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(pos1.position, pos2.position, Mathf.PingPong(Time.time, 1));
    }
}
