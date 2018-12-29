using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
         if(collision.collider.gameObject.CompareTag("Bullet")) {
             Debug.Log("is bullet");
			 this.GetComponent<Rigidbody>().isKinematic = false;
         }
		 Debug.Log("hit");
     } 
}
