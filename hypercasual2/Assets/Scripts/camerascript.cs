using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject player;
    
    Charactercontroller characterController;
    private void Start()
    {
        characterController = player.GetComponent<Charactercontroller>();
    }
    void Update()
    {
        float z = Input.GetAxis("Horizontal");
        Vector3 camerapos = transform.position;
        camerapos.z += -z * Time.deltaTime * characterController.rightleftspeed;
        camerapos.z = Mathf.Clamp(camerapos.z, -2.88f, 2.88f);
        transform.position = camerapos;
        transform.position = new Vector3(player.transform.position.x + characterController.i, transform.position.y, transform.position.z);
    }
}
