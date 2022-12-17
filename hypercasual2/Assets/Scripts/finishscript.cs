using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishscript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Charactercontroller>().canmove = false;
        other.gameObject.GetComponent<Animator>().SetTrigger("win");
        other.transform.position = new Vector3(other.transform.position.x, 0, other.transform.position.z);
        Camera.main.gameObject.GetComponent<camerascript>().height = 8;
        Camera.main.gameObject.GetComponent<camerascript>().distance = 9;
        Time.timeScale = 0.4f;
    }
}
