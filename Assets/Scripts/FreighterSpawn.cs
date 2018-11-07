using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreighterSpawn : MonoBehaviour {
    public GameObject Moon, Mars, Freighter;
    GameObject SpawnedFreighter;
    public Vector3 FreighterMove;
    public int AmountSpawned;

    // Use this for initialization
    void Start() {
        FreighterMove = Moon.transform.position - Mars.transform.position;
	}
	public void SpawnFreighter ()
    {
        Debug.Log("OK");
        SpawnedFreighter = Instantiate(Freighter, Mars.transform.position, Quaternion.identity);
        Debug.Log("Spawned");

    }
	// Update is called once per frame
	void Update () {

	}
    
    
    
    
    
    
    
 

}
