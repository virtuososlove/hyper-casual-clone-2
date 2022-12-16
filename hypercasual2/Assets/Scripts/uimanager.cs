using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uimanager : MonoBehaviour
{
    public Text mantext;
    public Text cointext;
    void Start()
    {
        
    }
    private void Update()
    {
        cointext.text = Charactercontroller.coin.ToString();

        mantext.text = Charactercontroller.mancounter.ToString();

    }
    void mantextupdater()
    {
    }
    void cointextupdater()
    {
        

    }
}
