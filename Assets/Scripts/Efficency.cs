using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efficency : MonoBehaviour {
    public float MineLevel, BankLevel, FreighterLevel;
    RescourcesOnMars RescourcesOnMars;

	void Start () {
        MineLevel = 1;
        BankLevel = 1;
        FreighterLevel = 1;
	}

    public void MineUpgrade()
    {
        if (RescourcesOnMars.Money < 100 * MineLevel)
        {
            RescourcesOnMars.Money = RescourcesOnMars.Money - (100 * MineLevel);
            MineLevel++;
        }
    }

    public void BankUpgrade()
    {
        if (RescourcesOnMars.Money < (100 * BankLevel))
        {
            RescourcesOnMars.Money = RescourcesOnMars.Money - (100 * BankLevel);
            BankLevel++;
        }
    }

    public void FreigtherUpgrade()
    {

    }
}
