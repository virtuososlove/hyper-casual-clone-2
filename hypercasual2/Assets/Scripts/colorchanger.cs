using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour
{
    public Material purple;
    public Material orange;

    public Material green;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("purpleportal"))
        {
            other.GetComponent<Charactercontroller>().currentcolor = "purple";
            other.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = purple;
            other.transform.GetChild(3).gameObject.SetActive(true);
            other.GetComponent<Animator>().SetInteger("color", 3);
        }
        if (gameObject.CompareTag("orangeportal"))
        {
            other.GetComponent<Charactercontroller>().currentcolor = "orange";
            other.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = orange;
            other.GetComponent<Animator>().SetInteger("color", 1);
        }
        if (gameObject.CompareTag("greenportal"))
        {
            other.GetComponent<Charactercontroller>().currentcolor = "green";
            other.GetComponent<Animator>().SetInteger("color", 2);
            other.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = green;

        }
    }
}
