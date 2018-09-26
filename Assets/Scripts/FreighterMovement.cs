using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreighterMovement : MonoBehaviour {
    public GameObject Moon, Mars, Freighter;
    GameObject SpawnedFreighter;
    public Vector3 FreighterMove;

    // Use this for initialization
    void Start() {
        FreighterMove = Moon.transform.position - Mars.transform.position;
	}
	public void SpawnFreighter ()
    {
        SpawnedFreighter = Instantiate(Freighter, new Vector3(5.16f, 0.3f), Quaternion.identity);
        Debug.Log("Spawned");

    }
	// Update is called once per frame
	void Update () {
        if (SpawnedFreighter != null)
        {


            SpawnedFreighter.transform.Translate(FreighterMove/200);
        }
     
	}
    
    
    
    
    
    
    
 

}
