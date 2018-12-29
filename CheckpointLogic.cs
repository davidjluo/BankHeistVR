using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointLogic : MonoBehaviour {

	public GameObject c1;
	public GameObject c2;
	public Light[] lightArr;
	public Color colorA = Color.red;
	public Color colorB;
	public float speed = 1.0f;
	public AudioSource asc;
	public bool alarm = true;
	public AudioClip triggered;
	public AudioClip completed;
	
	// Use this for initialization
	void Start () {
		colorB = lightArr[0].color;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!c1.GetComponent<Rigidbody>().isKinematic && !c2.GetComponent<Rigidbody>().isKinematic) {
			for(var i = 0; i < lightArr.Length; i ++) {
				lightArr[i].color = colorB;
			}
			asc.Stop();
			asc.PlayOneShot(completed);
			this.gameObject.SetActive(false);
		}
	}
	
	void OnCollisionEnter(Collision collision) {
         if(!collision.collider.gameObject.CompareTag("Bullet")) {
		     if(alarm) {
			 	asc.Stop();
			     asc.PlayOneShot(triggered);
			     alarm = false;
			 }
			 if(c1.GetComponent<Rigidbody>().isKinematic || c2.GetComponent<Rigidbody>().isKinematic) {
				for(var i = 0; i < lightArr.Length; i ++) {
					lightArr[i].color = colorA;
				}
			 }
         }
     } 
	 
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointLogic : MonoBehaviour {

	public GameObject c1;
	public GameObject c2;
	public GameObject[] whiteLightArr;
	public GameObject[] redLightarr;
	public float speed = 1.0f;
	public AudioSource asc;
	public bool alarm = true;
	public AudioClip triggered;
	public AudioClip completed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!c1.GetComponent<Rigidbody>().isKinematic && !c2.GetComponent<Rigidbody>().isKinematic) {
			for(var i = 0; i < whiteLightArr.Length; i ++) {
				whiteLightArr[i].SetActive(true);
			}
			for(var i = 0; i < redLightarr.Length; i ++) {
				redLightarr[i].SetActive(false);
			}
			asc.Stop();
			asc.PlayOneShot(completed);
			this.gameObject.SetActive(false);
		}
	}
	
	void OnCollisionEnter(Collision collision) {
         if(!collision.collider.gameObject.CompareTag("Bullet")) {
		     if(alarm) {
			 	asc.Stop();
			    asc.PlayOneShot(triggered);
			    alarm = false;
			 }
			 if(c1.GetComponent<Rigidbody>().isKinematic || c2.GetComponent<Rigidbody>().isKinematic) {
				for(var i = 0; i < whiteLightArr.Length; i ++) {
					whiteLightArr[i].SetActive(false);
				}
				for(var i = 0; i < redLightarr.Length; i ++) {
					redLightarr[i].SetActive(true);
				}
			 }
         }
     } 
	 
}

*/