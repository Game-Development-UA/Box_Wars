

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class MC_movement : MonoBehaviour {
	public float moveSpeed;
	public float horizMoveSpeed;
    public int lanenum = 2;
    public string controlLocked = "n";
    public float jumppower;

    public Rigidbody body;
    
    //death particle
    public Transform boomObj;

    float horiz = 0;
    // Use this for initialization
    // void Start () {
    //     body.velocity = new Vector3(0, GM.vertVel, 4);
    // }
    
    // Update is called once per frame
    void Update () {
    	horiz = Input.GetAxis( "Horizontal" ) * horizMoveSpeed;

        // if (Input.GetKeyDown (moveL) && (lanenum > 1) && (controlLocked == "n")){
        //     hvelocity = -2;//move left
        //     StartCoroutine (stopSlide ());
        //     lanenum -= 1;
        //     controlLocked = "y";
        // }

        // if (Input.GetKeyDown (moveR) && (lanenum < 3) && (controlLocked == "n")){
        //     hvelocity = 2;//move left
        //     StartCoroutine (stopSlide ());
        //     lanenum += 1;
        //     controlLocked = "y";
        // }
    }
    
    
    void FixedUpdate() {
    	body.velocity = new Vector3( horiz, body.velocity.y, moveSpeed );
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Lethal") {
            Destroy (gameObject);
            // GM.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            GM.lvlCompStatus = "Fail!";
        }
        // if (other.gameObject.tag == "Powerup") {
        //     Destroy(other.gameObject);
        //     //add powerup effects
        // }
    }

    void OnTriggerEnter(Collider other){
        //vertical movement on ramp
        // if (other.gameObject.name == "RampBotTrigger") {
        //     GM.vertVel = 1.7f;
        // }
        // // stop vert movement after ramp
        // if (other.gameObject.name == "RampTopTrigger") {
        //     GM.vertVel = 0;
        // }
        //loads lvl complete scene when you hit exit collider
        if (other.gameObject.name == "Exit(Clone)") {
            SceneManager.LoadScene ("LevelComplete");
            GM.lvlCompStatus = "Success!";
        }
        //picks up coins
        // if (other.gameObject.name == "Coin(Clone)" || other.gameObject.name == "Coin") {
        //     Destroy(other.gameObject);
        //     GM.coinTotal += 1;
        // }

    }

    // IEnumerator stopSlide() {
    //     yield return new WaitForSeconds(.5f);
    //     hvelocity = 0;
    //     controlLocked = "n";
    // }
 //   private void Update(){
 //   bool jump = Input.GetButtonDown("Jump");
  //  if (jump){
  //      man_move.AddForce(new Vector3(0f,jumppower),ForceMode.Impulse);
  //     }
  //  }
}
