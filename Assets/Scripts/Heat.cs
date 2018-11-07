using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heat : MonoBehaviour
{
    public FreighterSpawn GetFreighter;
    public RescourcesOnMars rescources;
    public float HEAT;
    public Text HeatText;
    
    void Start()
    {

    }
    // Update is called once per frame
    void Update () {
        HEAT = rescources.Bank * 0.001f + rescources.MaterialMine * 0.001f + GetFreighter.AmountSpawned*0.01f;
        if (HEAT > 1)
        {
            HEAT = 1;
        }
        HeatText.text = "Heat " + HEAT*100 + "%";
    }
}
