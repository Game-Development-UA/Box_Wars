using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine : MonoBehaviour {
public GameObject door_2_left; 

    UnityEngine.Coroutine corout;
    
    void OnCollisonEnter(Collision col) {
        if (col.gameObject.name == "Player") {
            corout = StartCoroutine(HideObject());
            print("test1");
        }
    }
    
    void OnCollisonExit(Collision col) {
        StopCoroutine (corout);
        print("test2");
    }
    
    IEnumerator HideObject () {
        yield return new WaitForSeconds(3);
        door_2_left.SetActive(false);
        print("test3");
    }
}
           
