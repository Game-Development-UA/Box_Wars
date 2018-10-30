using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

void OnCollisionEnter( Collision c){
    if (c.transform.name == "Player")
    {
        SceneManager.LoadScene("Main Menu");
    }
    
}
}