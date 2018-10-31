using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderDaErt : MonoBehaviour {
    GameObject Mün;
    public GameObject MainCamera;
    Animator animator;
    RescourcesOnMars RescourcesOnMars;
    bool DestroyErt;
    public GameObject[] UiObejcts;
    void Start()
    {
        RescourcesOnMars = MainCamera.GetComponent<RescourcesOnMars>();
        Mün = GameObject.Find("Moon");
        animator = Mün.GetComponent<Animator>();

    }
    public void Destroy()
    {
        if(RescourcesOnMars.Bank > 10000f && RescourcesOnMars.Material > 10000f){
            DestroyErt = true;
            animator.SetBool("CrashOrNot", DestroyErt);
            for (int i = 0; i < UiObejcts.Length; i++)
            {
                UiObejcts[i].SetActive(false);
            }
        }
    }
}
