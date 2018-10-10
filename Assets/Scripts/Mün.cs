using UnityEngine;
using UnityEngine.UI;

public class Mün : MonoBehaviour {
    public float MaterialOnMün;
    float MaterialOnMars;
    public RescourcesOnMars RescourcesOnMarsScript;
    public FreighterSpawn freighterSpawn;
    public Text text;

	//Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TransferToMün() {
        
        if(RescourcesOnMarsScript.Material > 20f)
        {
            RescourcesOnMarsScript.Material = RescourcesOnMarsScript.Material - 20;
            MaterialOnMün = MaterialOnMün + 20f;
            freighterSpawn.SpawnFreighter();
            text.text = "Material On Moon: " + MaterialOnMün;
        }
    }
}
