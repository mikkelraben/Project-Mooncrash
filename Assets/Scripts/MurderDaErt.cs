using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderDaErt : MonoBehaviour {
    public GameObject Mün;
    Animator animator;
    void Start()
    {
        Mün = GameObject.Find("Moon");
        animator = Mün.GetComponent<Animator>();
        animator.StopPlayback();
    }
    public void Destroy()
    {
        animator.StartPlayback();
    }
}
