using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rescources : MonoBehaviour {
    public Text Text;
    public float BankEfficieny, MaterialMineEfficieny;
    public float Money, Material;
    public int Bank, MaterialMine;
    public float BankIncome, MaterialMineIncome;
    public float PriceBank, PriceMaterialMine;
	
	// Update is called once per frame
	void Update () {
        PriceBank = Mathf.Pow(Bank,1.3f)+1;
        PriceMaterialMine = Mathf.Pow(MaterialMine, 2)+1;
        BankIncome = Bank * BankEfficieny;
        MaterialMineIncome = MaterialMine * MaterialMineEfficieny;
        Money = Money + BankIncome;
        Material = Material + MaterialMineIncome;

	}

}
