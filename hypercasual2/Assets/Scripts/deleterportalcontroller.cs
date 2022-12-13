using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleterportalcontroller : MonoBehaviour
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
        if (speed != 0)
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
        if (gameObject.CompareTag("0.5x"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;

                int i;
                for (i= (x-1); i > ((x/2)-1); i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                }
                Destroy(gameObject);
            }
        }
    }

    void x4funct(Collider other)
    {
        if (gameObject.CompareTag("0.25x"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                int i;
                for (i = (x - 1); i > ((x / 4) - 1); i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                }
                Destroy(gameObject);
            }
        }
    }

    void fnct_1(Collider other)
    {
        if (gameObject.CompareTag("-1"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x-1; i > x-2; i--)
                {

                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_2(Collider other)
    {
        if (gameObject.CompareTag("-2"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x - 1; i > x - 3; i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_3(Collider other)
    {
        if (gameObject.CompareTag("-3"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x - 1; i > x - 4; i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_5(Collider other)
    {
        if (gameObject.CompareTag("-5"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x - 1; i > x - 6; i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_10(Collider other)
    {
        if (gameObject.CompareTag("-10"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x - 1; i > x - 11; i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_15(Collider other)
    {
        if (gameObject.CompareTag("-15"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x - 1; i > x - 16; i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }

    void fnct_20(Collider other)
    {
        if (gameObject.CompareTag("-20"))
        {
            if (canadd == true)
            {
                canadd = false;
                int x = other.gameObject.transform.parent.transform.childCount;
                for (int i = x - 1; i > x - 21; i--)
                {
                    Destroy(player.transform.GetChild(i).gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }
}
