using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efficency : MonoBehaviour {
    public float MineLevel, BankLevel, FreighterLevel;
    public RescourcesOnMars RescourcesOnMars;
    public Mün Mün;


    void Start () {
        MineLevel = 1;
        BankLevel = 1;
        FreighterLevel = 1;
	}

    public void MineUpgrade()
    {
        if (RescourcesOnMars.Money > 30 * MineLevel)
        {
            RescourcesOnMars.Money = RescourcesOnMars.Money - (30 * MineLevel);
            RescourcesOnMars.MaterialMineEfficieny= RescourcesOnMars.MaterialMineEfficieny + 0.25f;
            MineLevel++;
        }
    }

    public void BankUpgrade()
    {
        if (RescourcesOnMars.Money > (30 * BankLevel))
        {
            RescourcesOnMars.Money = RescourcesOnMars.Money - (30 * BankLevel);
            RescourcesOnMars.BankEfficieny= RescourcesOnMars.BankEfficieny+ 0.25f;
            BankLevel++;
        }
    }

    public void FreigtherUpgrade()
    {
        if (RescourcesOnMars.Money > (30*FreighterLevel))
        {
            RescourcesOnMars.Money = RescourcesOnMars.Money - (30 * FreighterLevel);
            Mün.FreighterCargoBayMaximumCapacityLoadCarryingAbilities = Mün.FreighterCargoBayMaximumCapacityLoadCarryingAbilities + 0.2f;
            FreighterLevel++;
        }
    }
}
