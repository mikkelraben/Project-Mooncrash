using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour {
    public GameObject Missile;
    FlyMissile Fly;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void SpawnDaMissile (GameObject WhatFreighter){
        GameObject MissileToBeShat;
        MissileToBeShat = Instantiate(Missile, new Vector3(-4f, 0f, -2f), Quaternion.identity);
        Fly = MissileToBeShat.GetComponent<FlyMissile>();
    }
}
