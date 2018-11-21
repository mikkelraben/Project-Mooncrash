using UnityEngine;

public class FreighterMove : MonoBehaviour {
    public GameObject Moon, Mars;
    public Vector3 FreighterVector3;
    public float Progress;
    public float Speed;
    public Heat Heat;
    public SpawnMissile Spawn;
    // Use this for initialization
    void Start () {
        FreighterVector3 = Moon.transform.position - Mars.transform.position;
        Heat = GameObject.Find("Main Camera").GetComponent<Heat>();
        if (Random.Range(1f, 0f) < Heat.HEAT)
        {
            Spawn = GameObject.Find("Main Camera").GetComponent<SpawnMissile>();
        }
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
