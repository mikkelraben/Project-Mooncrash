using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructuresMars : MonoBehaviour {
    public RescourcesOnMars RescourcesOnMars;
    public GameObject BankStructure, Minestructure;
	
    // Use this for initialization
	void Start () {
        BankStructure.SetActive(false);
        Minestructure.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (RescourcesOnMars.Bank == 1)
        {
            
        }
		if (RescourcesOnMars.Bank >= 1)
        {

        }
	}
}
