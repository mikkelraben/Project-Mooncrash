using UnityEngine;

public class Mün : MonoBehaviour {
    public float MaterialOnMün;
    float MaterialOnMars;
    public RescourcesOnMars RescourcesOnMarsScript;
    public FreighterSpawn freighterSpawn;

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
        }
    }
}
