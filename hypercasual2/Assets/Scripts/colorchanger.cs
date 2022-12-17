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
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("purpleportal"))
            {
                other.GetComponent<Charactercontroller>().currentcolor = "purple";
                other.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = purple;
                other.transform.GetChild(3).gameObject.GetComponent<ParticleSystem>().Play();
                other.GetComponent<Animator>().SetInteger("color", 3);
            }
            if (gameObject.CompareTag("orangeportal"))
            {
                other.GetComponent<Charactercontroller>().currentcolor = "orange";
                other.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = orange;
                other.transform.GetChild(5).gameObject.GetComponent<ParticleSystem>().Play();

                other.GetComponent<Animator>().SetInteger("color", 1);
            }
            if (gameObject.CompareTag("greenportal"))
            {
                other.GetComponent<Charactercontroller>().currentcolor = "green";
                other.GetComponent<Animator>().SetInteger("color", 2);
                other.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = green;
                other.transform.GetChild(4).gameObject.GetComponent<ParticleSystem>().Play();


            }
        }
        
    }
}
