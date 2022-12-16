using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charactercontroller : MonoBehaviour
{
    public float speed;
    public float rightleftspeed;
    public float i = -5;
    public static int mancounter = 1;
    public bool canstart = false;
    public ParticleSystem system;
    public ParticleSystem morsystem;
    public ParticleSystem yesilsystem;

    public ParticleSystem morrenkgecis;
    public ParticleSystem turuncurenkgecis;
    public ParticleSystem yesilrenkgecis;
    public Image line;
    public Image finger;
    Animator chanm;
    bool candelay;
    
    float jk = 0.30f;
    public string currentcolor = "orange";
    public static int coin;
    void Start()
    {
        chanm = GetComponent<Animator>();
        currentcolor = "orange";
        coin = 0;

    }

    void Update()
    {
        if(canstart == false)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B))
            {
                chanm.SetTrigger("start");
                line.gameObject.SetActive(false);
                finger.gameObject.SetActive(false);
                candelay = true; 
            }
            if(candelay == true)
            {
                jk -= Time.deltaTime;
                if (jk <= 0)
                {
                    canstart = true;
                }

            }
        }
        else
        {
            
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            float z = Input.GetAxis("Horizontal");
            Vector3 charpos = transform.position;
            charpos.z += -z * Time.deltaTime * rightleftspeed;
            charpos.z = Mathf.Clamp(charpos.z, -2.88f, 2.88f);
            transform.position = charpos;
        }
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(currentcolor)) 
        {
            chanm.SetInteger("color", 0);
            if (!chanm.GetCurrentAnimatorStateInfo(1).IsName("parlama"))
            {
                chanm.SetTrigger("deymetrigger");    
            }
            mancounter += 1;
            gameObject.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            Camera.main.transform.position += new Vector3(0, 0.1f, 0);
            if(currentcolor == "orange")
            {
                system.Play();
            }
            if(currentcolor == "purple")
            {
                morsystem.Play();

            }
            if(currentcolor == "green")
            {
                yesilsystem.Play();
            }
            system.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            yesilsystem.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            morsystem.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);

            morrenkgecis.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            yesilrenkgecis.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);
            turuncurenkgecis.transform.localScale += new Vector3(0.017f, 0.017f, 0.017f);


            i -= 0.1f;
            Destroy(other.gameObject);

        }
        else if (!other.gameObject.CompareTag("Ground") && !other.gameObject.CompareTag("wall") && !other.gameObject.CompareTag("orangeportal") && !other.gameObject.CompareTag("greenportal") && !other.gameObject.CompareTag("purpleportal") && !other.gameObject.CompareTag("coin"))
        {
            mancounter -= 1;
            gameObject.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            Camera.main.transform.position += new Vector3(0, -0.1f, 0);
            i += 0.1f;
            system.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            yesilsystem.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            morsystem.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);

            morrenkgecis.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            yesilrenkgecis.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            turuncurenkgecis.transform.localScale -= new Vector3(0.017f, 0.017f, 0.017f);
            Destroy(other.gameObject);
           
        }
        else if (!other.gameObject.CompareTag("coin"))
        {
            coin += 1;
        }
    }


}
