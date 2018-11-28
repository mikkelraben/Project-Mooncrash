using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsBuildingSpawning : MonoBehaviour {
    public RescourcesOnMars RescourcesOnMars;
    public GameObject SpaceColony;
    public GameObject MarsMine;
    public float Scale;
    void Start()
    {
        SpaceColony.transform.localScale.Set(0f, 0f, 0f);
        MarsMine.transform.localScale.Set(0f, 0f, 0f);
    }
    // Update is called once per frame
    void Update () {

        SpaceColony.transform.localScale = new Vector3(RescourcesOnMars.Bank * Scale, RescourcesOnMars.Bank * Scale, RescourcesOnMars.Bank * Scale);
        MarsMine.transform.localScale = new Vector3(RescourcesOnMars.MaterialMine*Scale, RescourcesOnMars.MaterialMine * Scale, RescourcesOnMars.MaterialMine * Scale);
    }
}
