using UnityEngine;
using UnityEngine.UI;

public class Mün : MonoBehaviour {
    public float MaterialOnMün;
    float MaterialOnMars;
    public RescourcesOnMars RescourcesOnMarsScript;
    public FreighterSpawn freighterSpawn;
    public Text text;
    public Text MaterialText;
    public float FreighterCargoBayMaximumCapacityLoadCarryingAbilities;

	//Use this for initialization
	void Start () {
        FreighterCargoBayMaximumCapacityLoadCarryingAbilities = 1;
	}
	
	// Update is called once per frame
	void Update () {
        MaterialText.text = "Transfer material (" + FreighterCargoBayMaximumCapacityLoadCarryingAbilities.ToString("#.00") + ")";
    }
    public void TransferToMün() {
        
        if(RescourcesOnMarsScript.Material > 20f*FreighterCargoBayMaximumCapacityLoadCarryingAbilities)
        {
            RescourcesOnMarsScript.Material = RescourcesOnMarsScript.Material - 20f*FreighterCargoBayMaximumCapacityLoadCarryingAbilities;
            MaterialOnMün = MaterialOnMün + FreighterCargoBayMaximumCapacityLoadCarryingAbilities;
            freighterSpawn.SpawnFreighter();
            MaterialText.text = "Transfer material(" + FreighterCargoBayMaximumCapacityLoadCarryingAbilities.ToString("#.00") + ")";
            text.text = "Material On Moon: " + MaterialOnMün.ToString("#.00");
        }
    }
}
