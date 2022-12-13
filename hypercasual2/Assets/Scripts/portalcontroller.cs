using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcontroller : MonoBehaviour
{
    public float speed = 1f;
    public GameObject crowdmemberpref;
    GameObject player;
    bool canadd = true;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        Vector3 a = new Vector3(transform.position.x, transform.position.y, 2.22f);
        Vector3 b = new Vector3(transform.position.x, transform.position.y, -2.22f);
        if(speed != 0)
        {
            transform.position = Vector3.Lerp(a, b, Mathf.PingPong(Time.time, speed));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        x2funct(other);
        x4funct(other);
        fnct_1(other);
        fnct_2(other);
        fnct_3(other);
        fnct_5(other);
        fnct_10(other);
        fnct_15(other);
        fnct_20(other);
    }

    void x2funct(Collider other)
    {
        if (gameObject.CompareTag("2x"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.gameObject.transform.childCount;
                for (int i = 0; i < (x); i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void x4funct(Collider other)
    {
        if (gameObject.CompareTag("4x"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.gameObject.transform.childCount;
                for (int i = 0; i < (3*x); i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_1(Collider other)
    {
        if (gameObject.CompareTag("+1"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 1; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_2(Collider other)
    {
        if (gameObject.CompareTag("+2"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 2; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_3(Collider other)
    {
        if (gameObject.CompareTag("+3"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 3; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_5(Collider other)
    {
        if (gameObject.CompareTag("+5"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 5; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_10(Collider other)
    {
        if (gameObject.CompareTag("+10"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 10; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_15(Collider other)
    {
        if (gameObject.CompareTag("+15"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 15; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_20(Collider other)
    {
        if (gameObject.CompareTag("+20"))
        {
            if (canadd == true)
            {
                canadd = false;
                for (int i = 0; i < 20; i++)
                {
                    GameObject crowdmember = Instantiate(crowdmemberpref, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 0));
                    crowdmember.transform.parent = player.transform;
                    Destroy(gameObject);
                }
            }
        }
    }
}
