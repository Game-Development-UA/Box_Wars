using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coroutine : MonoBehaviour {
public GameObject door_2_left; 

    
    UnityEngine.Coroutine corout;
    
    
        
    
    void OnCollisonEnter(Collision col) {
        if (col.gameObject.name == "Player") {
            print("test1");
        }
    }
    
    void Start () {
        
        StartCoroutine(countdown());
        
    }
    
    IEnumerator WaitToResumeGame (){
        
        float start = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < start + 1f){
            yield return 0;
        }
    }
    IEnumerator countdown(){
        Time.timeScale = 0;
       yield return WaitToResumeGame(); 
       Debug.Log("wainting");
       yield return WaitToResumeGame(); 
       Debug.Log("wainting2");
       yield return WaitToResumeGame(); 
       Debug.Log("wainting3"); 
       Time.timeScale = 1;
    }
}  