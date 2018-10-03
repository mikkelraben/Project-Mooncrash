using UnityEngine;

public class Mün : MonoBehaviour {
    public float MaterialOnMün;
    float MaterialOnMars;
    public RescourcesOnMars RescourcesOnMarsScript;
    FreighterSpawn freighterSpawn;

	//Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TransferToMün() {
        MaterialOnMars = RescourcesOnMarsScript.Material;
        if(MaterialOnMars > 20)
        {
            MaterialOnMars = MaterialOnMars - 20;
            MaterialOnMün = MaterialOnMün + 20;
            freighterSpawn.SpawnFreighter();
        }
    }
}
