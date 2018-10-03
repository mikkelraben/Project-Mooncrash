using UnityEngine;

public class Mün : MonoBehaviour {
    public float MaterialOnMün;
    float MaterialOnMars;
    public RescourcesOnMars Rescources;

	/     Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TransferToMün(){
        //MaterialOnMars = Rescources.Material;
        if (MaterialOnMars > 20)
        {
            MaterialOnMars = MaterialOnMars - 20;
            MaterialOnMün = MaterialOnMün + 20;
            TransferToMün();
        }
    }
}
