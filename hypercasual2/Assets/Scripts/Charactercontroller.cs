using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charactercontroller : MonoBehaviour
{
    public float speed;
    public float rightleftspeed;
    public float i = -4.5f;
    public static int mancounter = 1;
    public bool canstart = false;
    public ParticleSystem system;
    public ParticleSystem morsystem;
    public ParticleSystem yesilsystem;
    public Animator textanim;
    public ParticleSystem morrenkgecis;
    public ParticleSystem turuncurenkgecis;
    public ParticleSystem yesilrenkgecis;
    public ParticleSystem kurukafa;
    public Image line;
    public Image finger;
    Animator chanm;
    bool candelay;
    public float b�y�meorani = 0.02f;
    public float camerab�y�mesi;
    float jk = 0.30f;
    public string currentcolor = "orange";
    public static int coin;
    public bool canmove = true;
    public GameObject mycamera;
    void Start()
    {
        chanm = GetComponent<Animator>();
        currentcolor = "orange";
        coin = 0;
        camerab�y�mesi = b�y�meorani * 2.5f;
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
            if(canmove == true)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                float z = Input.GetAxis("Horizontal");
                Vector3 charpos = transform.position;
                charpos.z += -z * Time.deltaTime * rightleftspeed;
                charpos.z = Mathf.Clamp(charpos.z, -2.88f, 2.88f);
                transform.position = charpos;
            }
           
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
            textanim.SetTrigger("active");
            mancounter += 1;
            if(mancounter == 5)
            {
                b�y�meorani -= 0.0005f;
                camerab�y�mesi = b�y�meorani * 2.5f;
            }
            if(mancounter == 10)
            {
                b�y�meorani -= 0.001f;
                camerab�y�mesi = b�y�meorani * 2.5f;
            }
            if (mancounter == 15)
            {
                b�y�meorani -= 0.001f;
                camerab�y�mesi = b�y�meorani * 2.5f;
            }
            if (mancounter == 20)
            {
                b�y�meorani -= 0.002f;
                camerab�y�mesi = b�y�meorani * 2.5f;
            }
            if (mancounter == 25)
            {
                b�y�meorani -= 0.002f;
                camerab�y�mesi = b�y�meorani * 2.5f;
            }
            if (mancounter == 30)
            {
                b�y�meorani -= 0.002f;
                camerab�y�mesi = b�y�meorani * 2.5f;
            }
            gameObject.transform.localScale += new Vector3(b�y�meorani,b�y�meorani,b�y�meorani);
            //Camera.main.transform.position += new Vector3(0, 0.12f, 0);
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
            system.transform.localScale += new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);
            yesilsystem.transform.localScale += new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);
            morsystem.transform.localScale += new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);

            mycamera.GetComponent<camerascript>().distance += camerab�y�mesi;
            mycamera.GetComponent<camerascript>().height += camerab�y�mesi;

            //i -= 0.08f;
            Destroy(other.gameObject);

        }
        else if (!other.gameObject.CompareTag("Ground") && !other.gameObject.CompareTag("wall") && !other.gameObject.CompareTag("orangeportal") && !other.gameObject.CompareTag("greenportal") && !other.gameObject.CompareTag("purpleportal") && !other.gameObject.CompareTag("coin"))
        {
           
            mancounter -= 1;
            gameObject.transform.localScale -= new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);
            //Camera.main.transform.position += new Vector3(0, -0.12f, 0);
            //i += 0.08f;
            system.transform.localScale -= new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);
            yesilsystem.transform.localScale -= new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);
            morsystem.transform.localScale -= new Vector3(b�y�meorani, b�y�meorani, b�y�meorani);
            kurukafa.Play();
            Destroy(other.gameObject);
           
        }
        else if (other.gameObject.CompareTag("coin"))
        {
            coin += 1;
            Destroy(other.gameObject);

        }
    }


}
