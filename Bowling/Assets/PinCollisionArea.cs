using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollisionArea : MonoBehaviour {

public Pin pin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnTriggerEnter (Collider otherCollider) {
        if (otherCollider.tag == "Floor") {
            pin.OnTouchFloor ();
        }
    }
    
}
