using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactercontroller : MonoBehaviour
{
    public float speed;
    public float rightleftspeed;
    public float i = -5;
    public static int mancounter = 1;

    public ParticleSystem system;
    void Start()
    {

    
    }

    void Update()
    {
        
        transform.Translate(Vector3.forward* Time.deltaTime * speed);
        float z = Input.GetAxis("Horizontal");
        Vector3 charpos = transform.position;
        charpos.z += -z * Time.deltaTime * rightleftspeed;
        charpos.z = Mathf.Clamp(charpos.z, -2.88f, 2.88f);
        transform.position = charpos;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("orangechar")) 
        {
            if (!GetComponent<Animator>().GetCurrentAnimatorStateInfo(1).IsName("parlama"))
            {
                GetComponent<Animator>().SetTrigger("deymetrigger");
                
                    
            }
            mancounter += 1;
            gameObject.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            Camera.main.transform.position += new Vector3(0, 0.1f, 0);
            system.Play();
            system.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            i -= 0.1f;
            Destroy(other.gameObject);

        }
        else if (!other.gameObject.CompareTag("Ground") && !other.gameObject.CompareTag("wall"))
        {
            mancounter -= 1;
            gameObject.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            Camera.main.transform.position += new Vector3(0, -0.1f, 0);
            i += 0.1f;
            Destroy(other.gameObject);
           
        }
    }


}
