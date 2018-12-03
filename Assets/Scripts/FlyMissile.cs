using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMissile : MonoBehaviour {
    public Vector3 Vector;
    public float angle, speed;
    GameObject FreighterObject;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Vector = FreighterObject.transform.position - transform.position;
        if (Vector.magnitude > 1*speed)
        {
            Vector = Vector.normalized*speed;
        }
        transform.position = transform.position + Vector;
        if (Vector.magnitude < 0.15f)
        {
            Destroy(gameObject);
            Destroy(FreighterObject);
        }
        angle = Mathf.Atan2(Vector.y, Vector.x)*100;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        Debug.Log(transform.rotation.eulerAngles);
        Debug.Log(Mathf.Atan2(Vector.y, Vector.x)*10);
    }
    public void GIVEMEINFO (GameObject Freighter){
        FreighterObject = Freighter;
    }
}
