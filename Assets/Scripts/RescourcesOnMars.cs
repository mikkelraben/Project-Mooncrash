﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RescourcesOnMars : MonoBehaviour {
    public Text MoneyText,MaterialText;
    public Button MoneyButton, MaterialButton;
    public float BankEfficieny, MaterialMineEfficieny = .05f;
    public float Money, Material;
    public int Bank, MaterialMine;
    public float BankIncome, MaterialMineIncome;
    public float PriceBank, PriceMaterialMine;
    public GameObject Mars;

    private void Start()
    {
        BankEfficieny = 1;
        MaterialMineEfficieny = 1;

       
    }
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
        MoneyText.text = "Money: " + Money.ToString("#.00");
        MaterialText.text = "Material: " + Material.ToString("#.00");
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