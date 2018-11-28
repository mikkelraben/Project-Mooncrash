using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour {
    public GameObject Missile, WhatFreighter;
    FlyMissile Fly;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SpawnDaMissile (GameObject Freighter){
        WhatFreighter = Freighter;
        GameObject MissileToBeShat;
        MissileToBeShat = Instantiate(Missile, new Vector3(-4f, 0f, -2f), Quaternion.identity);
        Fly = MissileToBeShat.GetComponent<FlyMissile>();
        Fly.Object = WhatFreighter;
    }
}
