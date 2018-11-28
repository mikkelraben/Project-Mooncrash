using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMissile : MonoBehaviour {
    public GameObject Object;
    public Vector3 Move;
    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Move = gameObject.transform.position - Object.transform.position;
        transform.LookAt(Object.transform.position);
        if (Move.magnitude > 1)
        {

            Move = Move.normalized * Speed;
            Debug.Log("HERRO");
        }
        gameObject.transform.position = gameObject.transform.position + -Move;

        if (Move == Vector3.zero)
        {
            Destroy(gameObject);
        }
        
    }
    void GIVEMEINFO (GameObject Freighter){
        Object = Freighter;
    }
}
