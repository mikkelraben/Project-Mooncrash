using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsBuildingSpawning : MonoBehaviour {
    public Efficency Efficency;
    public GameObject spaceColony;
    public GameObject MarsMine;
   
	
	// Update is called once per frame
	void Update () {
        transform.localScale.Set(Efficency.BankLevel * 0.1, Efficency.BankLevel * 0.1, Efficency.BankLevel * 0.1, );
        }
}
