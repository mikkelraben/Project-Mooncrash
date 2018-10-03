using UnityEngine;

public class FreighterMove : MonoBehaviour {
    public GameObject Moon, Mars;
    public Vector3 FreighterVector3;
    public float Progress;
    public float Speed;
    // Use this for initialization
    void Start () {
        FreighterVector3 = Moon.transform.position - Mars.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Progress = Progress + Speed;
        transform.position = Mars.transform.position + (FreighterVector3 * Progress);
        if (Progress >= 1)
        {
            Destroy(gameObject);
        }
	}
}
