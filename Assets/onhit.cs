using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onhit : MonoBehaviour {

	public void OnCollisionEnter(Collision onhit){
        if (onhit.collider.gameObject.name == "Player"){          
            Destroy(onhit.collider.gameObject);
            

        }
 
    }
    
	void Update () {
		
	}
}
