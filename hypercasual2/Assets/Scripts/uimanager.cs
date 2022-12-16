using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI mantext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mantext.text = Charactercontroller.mancounter.ToString();
    }
}
