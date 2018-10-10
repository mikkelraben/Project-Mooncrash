using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseMenus : MonoBehaviour {
    public GameObject TheObjectThatShaltBeToglth;
    public void OpenCloseMenu(){
        TheObjectThatShaltBeToglth.SetActive(!TheObjectThatShaltBeToglth.activeSelf);
    }
}
