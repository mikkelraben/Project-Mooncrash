using UnityEngine;

public class FreighterMove : MonoBehaviour {
    public GameObject Moon, Mars;
    public Vector3 FreighterVector3;
    public float Progress;
    public float Speed;
    public Heat Heat;
    public SpawnMissile Spawn;
    public Mün Mün;
    // Use this for initialization
    void Start () {
        FreighterVector3 = Moon.transform.position - Mars.transform.position;
        Heat = GameObject.Find("Main Camera").GetComponent<Heat>();
        if (Random.Range(1.2f, 0f) < Heat.HEAT)
        {
            Spawn = GameObject.Find("Main Camera").GetComponent<SpawnMissile>();
            Spawn.SpawnDaMissile(gameObject);
            Mün = GameObject.Find("Main Camera").GetComponent<Mün>();
            Mün.MaterialOnMün = Mün.MaterialOnMün - 20f * Mün.FreighterCargoBayMaximumCapacityLoadCarryingAbilities;
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
