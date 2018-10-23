using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button2game : MonoBehaviour {
    
    public void loadlevel(int levelindex){
        SceneManager.LoadScene(levelindex);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
