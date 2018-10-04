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
        MaterialOnMars = RescourcesOnMarsScript.Material;
    }
    public void TransferToMün() {
        MaterialOnMars = RescourcesOnMarsScript.Material;
        if (MaterialOnMars > 20f)
        {
            Debug.Log("works");
            RescourcesOnMarsScript.Material = RescourcesOnMarsScript.Material - 20;
            MaterialOnMün = MaterialOnMün + 20f;
            freighterSpawn.SpawnFreighter();
        }
        else{
            Debug.Log("NO");
        }
    }
}
