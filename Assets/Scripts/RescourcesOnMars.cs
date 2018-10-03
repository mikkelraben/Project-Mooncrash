using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RescourcesOnMars : MonoBehaviour {
    public Text MoneyText,MaterialText;
    public Button MoneyButton, MaterialButton;
    public float BankEfficieny = 1f, MaterialMineEfficieny = .05f;
    public float Money, Material;
    public int Bank, MaterialMine;
    public float BankIncome, MaterialMineIncome;
    public float PriceBank, PriceMaterialMine;

    // Update is called once per frame
    void Update() {
        PriceBank = Mathf.Pow(Bank, 1.3f) + 1;
        PriceMaterialMine = Mathf.Pow(MaterialMine, 2) + 1;
        BankIncome = Bank * BankEfficieny;
        MaterialMineIncome = MaterialMine * MaterialMineEfficieny;
        Money = Money + BankIncome * Time.deltaTime;
        Material = Material + MaterialMineIncome * Time.deltaTime;

        if (Money - PriceBank < 0) {
            MoneyButton.interactable = false;
        }
        else {
            MoneyButton.interactable = true;
        }
        if (Bank != 0)
        {
            if (Money - PriceMaterialMine < 0)
            {
                MaterialButton.interactable = false;
            }
            else
            {
                MaterialButton.interactable = true;
            }
       
        }
        else { MaterialButton.interactable = false; }
    
        //Do This last
        MoneyText.text = "Money: " + Money;
        MaterialText.text = "Material: " + Material;
	}
    public void MOARBANK(){
        Bank++;
        Money = Money - PriceBank;
    }
    public void MOARMINES() {
        MaterialMine++;
        Money = Money - PriceMaterialMine;
    }
}