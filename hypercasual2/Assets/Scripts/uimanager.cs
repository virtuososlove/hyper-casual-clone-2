using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimanager : MonoBehaviour
{
    public Text mantext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mantext.text = Charactercontroller.mancounter.ToString();
    }
}
