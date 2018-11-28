using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heat : MonoBehaviour
{
    public FreighterSpawn GetFreighter;
    public RescourcesOnMars rescources;
    public float HEAT;
    public Text HeatText;
    public Image FLAME;

    
    void Start()
    {

    }
    // Update is called once per frame
    void Update () {
        HEAT = ((rescources.Bank + rescources.MaterialMine) * 0.001f) * GetFreighter.AmountSpawned*0.001f;
        if (HEAT > 1)
        {
            HEAT = 1;
        }

        HeatText.text = "Heat : " + (Math.Round(HEAT * 100, 2)).ToString() +"%";
        FLAME.color = new Color(1, 1, 1, Mathf.Lerp(0f, 1f, HEAT));
        Debug.Log(Mathf.Lerp(0, 1, HEAT));
    }
}
