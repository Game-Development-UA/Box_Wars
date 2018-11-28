using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowonhit : MonoBehaviour {   //Kept bad capitalisation of slowonhit, in future name classes with capital letters
   public void OnCollisionEnter(Collision onhit){
      if(onhit.gameObject.name == "Player"){
          Debug.Log("Slowing Player");
          onhit.gameObject.GetComponent<MC_movement>().speed -= 3;
      }
   }
}
