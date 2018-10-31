﻿using UnityEngine;
using UnityEngine.UI;

public class Mün : MonoBehaviour {
    public float MaterialOnMün;
    float MaterialOnMars;
    public RescourcesOnMars RescourcesOnMarsScript;
    public FreighterSpawn freighterSpawn;
    public Text text;
    public float FreighterCargoBayMaximumCapacityLoadCarryingAbilities;

	//Use this for initialization
	void Start () {
        FreighterCargoBayMaximumCapacityLoadCarryingAbilities = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TransferToMün() {
        
        if(RescourcesOnMarsScript.Material > 20f*FreighterCargoBayMaximumCapacityLoadCarryingAbilities)
        {
            RescourcesOnMarsScript.Material = RescourcesOnMarsScript.Material - 20f*FreighterCargoBayMaximumCapacityLoadCarryingAbilities;
            MaterialOnMün = MaterialOnMün + 20f*FreighterCargoBayMaximumCapacityLoadCarryingAbilities;
            freighterSpawn.SpawnFreighter();
            text.text = "Material On Moon: " + MaterialOnMün;
        }
    }
}
